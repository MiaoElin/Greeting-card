using System.Numerics;
using Raylib_cs;
public class LetterEntity{
    public float timer;
    public float interval;
    public Color color;
    public float moveSpeed;
    public Vector2 pos;
    public Vector2[]path;
    public int pathIndex;
    public string text;
    public int fontSize;
    public LetterEntity(Vector2 []path,string  text){
        this.path=path;
        this.text=text;
    }
    public void Move(Vector2 dir,float dt){
        pos+=Raymath.Vector2Normalize(dir)*moveSpeed*dt;
    }
    public void Draw(){
        Raylib.DrawText(text,(int)pos.X,(int)pos.Y,fontSize,color);
    }
}