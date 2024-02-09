using System.Numerics;
using Raylib_cs;

public static class Program
{
    public static void Main()
    {
        Color lightPink = new Color();
        lightPink.R = 169;
        lightPink.G = 23;
        lightPink.B = 23;
        lightPink.A =255;
        Raylib.InitWindow(720, 888, "新年666888");
        Raylib.SetTargetFPS(150);
        LetterRepo leRepo = new LetterRepo();
        LetterEntity backGround = new LetterEntity(new Vector2[] { }, "");
        backGround.timer = 1f;
        LetterEntity H = LetterDomain.SpawnLetter(leRepo, new Vector2(0, -100), new Vector2[] { new Vector2(100, 200) }, 1, 300, Color.Black, "H", 120);
        LetterEntity A = LetterDomain.SpawnLetter(leRepo, new Vector2(720, 450), new Vector2[] { new Vector2(200, 200) }, 1, 400, Color.Black, "A", 120);
        LetterEntity p = LetterDomain.SpawnLetter(leRepo, new Vector2(0, -100), new Vector2[] { new Vector2(300, 200) }, 1, 300, Color.Black, "P", 120);
        LetterEntity p2 = LetterDomain.SpawnLetter(leRepo, new Vector2(100, -100), new Vector2[] { new Vector2(400, 200) }, 1, 200, Color.Black, "P", 120);
        LetterEntity y = LetterDomain.SpawnLetter(leRepo, new Vector2(600, -100), new Vector2[] { new Vector2(500, 200) }, 2, 200, Color.Black, "Y", 120);
        LetterEntity x = LetterDomain.SpawnLetter(leRepo, new Vector2(-100, 200), new Vector2[] { new Vector2(0, 200), new Vector2(150, 400) }, 2, 200, Color.Black, ">", 120);
        LetterEntity n = LetterDomain.SpawnLetter(leRepo, new Vector2(-100, 200), new Vector2[] { new Vector2(0, 100), new Vector2(200, 400) }, 2, 200, Color.Black, "N", 120);
        LetterEntity e = LetterDomain.SpawnLetter(leRepo, new Vector2(300, -100), new Vector2[] { new Vector2(300, 400) }, 2, 200, Color.Black, "E", 120);
        LetterEntity w = LetterDomain.SpawnLetter(leRepo, new Vector2(720, 300), new Vector2[] { new Vector2(400, 400) }, 2, 300, Color.Black, "W", 120);
        LetterEntity xx = LetterDomain.SpawnLetter(leRepo, new Vector2(720, 300), new Vector2[] { new Vector2(600, 300), new Vector2(500, 500), new Vector2(500, 325), new Vector2(500, 475), new Vector2(500, 350), new Vector2(500, 450), new Vector2(500, 375), new Vector2(500, 425), new Vector2(500, 390), new Vector2(500, 410), new Vector2(500, 400) }, 4, 300, Color.Black, "<", 120);
        LetterEntity y2 = LetterDomain.SpawnLetter(leRepo, new Vector2(300, 900), new Vector2[] { new Vector2(150, 600) }, 3, 300, Color.Black, "Y", 100);
        LetterEntity e2 = LetterDomain.SpawnLetter(leRepo, new Vector2(0, 900), new Vector2[] { new Vector2(250, 600) }, 3, 300, Color.Black, "E", 100);
        LetterEntity a = LetterDomain.SpawnLetter(leRepo, new Vector2(720, 450), new Vector2[] { new Vector2(350, 600) }, 3, 300, Color.Black, "A", 100);
        LetterEntity r = LetterDomain.SpawnLetter(leRepo, new Vector2(600, 900), new Vector2[] { new Vector2(450, 600) }, 3, 300, Color.Black, "R", 100);
        // LetterEntity smile1 = LetterDomain.SpawnLetter(leRepo, new Vector2(600, 900), new Vector2[] { new Vector2(250, 700) }, 3, 300, Color.Black, "^", 100);
        // LetterEntity smile2 = LetterDomain.SpawnLetter(leRepo, new Vector2(600, 900), new Vector2[] { new Vector2(300, 700) }, 3, 300, Color.Black, "_", 100);
        // LetterEntity smile3 = LetterDomain.SpawnLetter(leRepo, new Vector2(600, 900), new Vector2[] { new Vector2(360, 700) }, 3, 300, Color.Black, "^", 100);
        while (!Raylib.WindowShouldClose())
        {
            float dt = Raylib.GetFrameTime();
            Raylib.BeginDrawing();
            backGround.timer -= dt;
            if (backGround.timer > 0)
            {
                // System.Console.WriteLine(backGround.timer);s
                Raylib.ClearBackground(Color.White);
                if (backGround.timer >= 0.5f)
                {
                    Raylib.DrawText("RED", 275, 350, 100, lightPink);

                }
                else
                {
                    Raylib.DrawCircle(360, 450, 10/backGround.timer, lightPink);
                    // Raylib.DrawCircle(300, 400, 50, Color.Red);
                    // Raylib.DrawCircle(300, 400, 100, Color.Red);
                    // Raylib.DrawCircle(300, 400, 150, Color.Red);
                    // Raylib.DrawCircle(300, 400, 200, Color.Red);
                    // Raylib.DrawCircle(300, 400, 300, Color.Red);
                    // Raylib.DrawCircle(300, 400, 400, Color.Red);
                    // Raylib.DrawCircle(300, 400, 500, Color.Red);
                }

            }
            if (backGround.timer <= 0)
            {
                backGround.timer = 0;
                Raylib.ClearBackground(lightPink);
                leRepo.Forech((LetterEntity letter) =>
                {
                    LetterDomain.Move(letter, dt);
                    LetterDomain.Draw(letter);
                });
            }

            Raylib.EndDrawing();
        }
        Raylib.CloseWindow();
    }
    public static void Copy()
    {
        // LetterEntity H = LetterDomain.SpawnLetter(leRepo, new Vector2(0, -100), new Vector2[] { new Vector2(100, 100) }, 1, 300, Color.Black, "H", 120);
        // LetterEntity A = LetterDomain.SpawnLetter(leRepo, new Vector2(720, 450), new Vector2[] { new Vector2(200, 100) }, 1, 400, Color.Black, "A", 120);
        // LetterEntity p = LetterDomain.SpawnLetter(leRepo, new Vector2(0, -100), new Vector2[] { new Vector2(300, 100) }, 1, 300, Color.Black, "P", 120);
        // LetterEntity p2 = LetterDomain.SpawnLetter(leRepo, new Vector2(100, -100), new Vector2[] { new Vector2(400, 100) }, 1, 200, Color.Black, "P", 120);
        // LetterEntity y = LetterDomain.SpawnLetter(leRepo, new Vector2(600, -100), new Vector2[] { new Vector2(500, 100) }, 2, 200, Color.Black, "Y", 120);
        // LetterEntity x = LetterDomain.SpawnLetter(leRepo, new Vector2(-100, 200), new Vector2[] { new Vector2(0, 100), new Vector2(150, 300) }, 2, 200, Color.Black, ">", 120);
        // LetterEntity n = LetterDomain.SpawnLetter(leRepo, new Vector2(-100, 200), new Vector2[] { new Vector2(0, 100), new Vector2(200, 300) }, 2, 200, Color.Black, "N", 120);
        // LetterEntity e = LetterDomain.SpawnLetter(leRepo, new Vector2(300, -100), new Vector2[] { new Vector2(300, 300) }, 2, 200, Color.Black, "E", 120);
        // LetterEntity w = LetterDomain.SpawnLetter(leRepo, new Vector2(720, 300), new Vector2[] { new Vector2(400, 300) }, 2, 300, Color.Black, "W", 120);
        // LetterEntity xx = LetterDomain.SpawnLetter(leRepo, new Vector2(720, 300), new Vector2[] { new Vector2(600, 200), new Vector2(500, 400), new Vector2(500, 225), new Vector2(500, 375), new Vector2(500, 250), new Vector2(500, 350), new Vector2(500, 275), new Vector2(500, 325), new Vector2(500, 290), new Vector2(500, 310), new Vector2(500, 300) }, 4, 300, Color.Black, "<", 120);
        // LetterEntity y2 = LetterDomain.SpawnLetter(leRepo, new Vector2(300, 900), new Vector2[] { new Vector2(150, 500) }, 3, 300, Color.Black, "Y", 100);
        // LetterEntity e2 = LetterDomain.SpawnLetter(leRepo, new Vector2(0, 900), new Vector2[] { new Vector2(250, 500) }, 3, 300, Color.Black, "E", 100);
        // LetterEntity a = LetterDomain.SpawnLetter(leRepo, new Vector2(720, 450), new Vector2[] { new Vector2(350, 500) }, 3, 300, Color.Black, "A", 100);
        // LetterEntity r = LetterDomain.SpawnLetter(leRepo, new Vector2(600, 900), new Vector2[] { new Vector2(450, 500) }, 3, 300, Color.Black, "R", 100);
    }
}