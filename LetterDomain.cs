using System.Numerics;
using Raylib_cs;
public static class LetterDomain
{
    public static LetterEntity SpawnLetter(LetterRepo letterRepo, Vector2 pos, Vector2[] path, float timer, float moveSpeed, Color color, string text, int fontSize)
    {
        LetterEntity letter = new LetterEntity(path, text);
        letter.pos = pos;
        letter.interval = float.MaxValue;
        letter.timer = timer;
        letter.moveSpeed = moveSpeed;
        letter.color = color;
        letter.fontSize = fontSize;
        letter.pathIndex = 0;
        letter.isInEasing=false;
        letterRepo.Add(letter);
        return letter;
    }
    public static void Move(LetterEntity letter, float dt)
    {
        // System..WriteLine(letter.timer);
        // System.Console.WriteLine(dt);
        letter.timer -= dt;
        if (letter.timer > 0)
        {
            return;
        }
        if (letter.path == null)
        {
            return;
        }
        // 到达终点
        if (letter.pathIndex == letter.path.Length)
        {     
            return;
        }
        // if (letter.pathIndex >= letter.path.Length && letter.timer <= 0)
        // {
        //     return;
        // }
        // System.Console.WriteLine(letter.timer);
        Vector2 target = letter.path[letter.pathIndex];
        // System.Console.WriteLine(letter.pos);
        // System.Console.WriteLine(target);
        if (Vector2.DistanceSquared(target, letter.pos) <= 1f)
        {
            letter.pos = letter.path[letter.pathIndex];
            letter.timer=0;
            letter.pathIndex += 1;
            System.Console.WriteLine("arrived");
        }
        else
        {
            Vector2 dir = target - letter.pos;
            letter.Move(dir, dt);
        }
    }
    public static void Draw(LetterEntity letter)
    {
        letter.Draw();
    }
}