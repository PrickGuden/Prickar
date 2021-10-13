using UnityEngine;

public class Assignment1 : ProcessingLite.GP21
{
    private bool check = false;

    private Vector2 namePos = new Vector2(0, -1f);

    public float circleX = 1;
    public float circleY = 8;

    public float circleXadd = 0.01f;

    private void Update()
    {
        Background(163, 209, 197);
        ShittyRgbFlower();
        Animate();
        N(namePos);
        I(namePos);
        A(namePos);
    }

    public void ShittyRgbFlower()
    {
        NoStroke();
        Fill(255, 0, 0);
        Ellipse(circleX, circleY, 2, 0.5f);
        Fill(0, 255, 0);
        Ellipse(circleX, circleY, 0.5f, 2);
        Fill(0, 0, 255);
        Ellipse(circleX, circleY, 0.8f, 0.8f);

        circleX = circleX + circleXadd;

        if (circleX + 1 > Width)
        {
            circleXadd = -0.01f;
        }
        if (circleX < 1)
        {
            circleXadd = 0.01f;
        }
    }

    public void N(Vector2 pos)
    {
        Stroke(150, 150, 150);
        Fill(163, 209, 197);

        Line(pos.x + 2, pos.y + 8, pos.x + 2, pos.y + 2);
        Line(pos.x + 2, pos.y + 8, pos.x + 5, pos.y + 2);
        Line(pos.x + 5, pos.y + 8, pos.x + 5, pos.y + 2);
    }

    public void I(Vector2 pos)
    {
        Line(pos.x + 6, pos.y + 6, pos.x + 6, pos.y + 2);

        Line(pos.x + 5.3f, pos.y + 8, pos.x + 6, pos.y + 7);
        Line(pos.x + 6.7f, pos.y + 8, pos.x + 6, pos.y + 7);
        Line(pos.x + 6.7f, pos.y + 8, pos.x + 6, pos.y + 8.9f);
        Line(pos.x + 5.3f, pos.y + 8, pos.x + 6, pos.y + 9);
    }

    public void A(Vector2 pos)
    {
        Circle(pos.x + 9, pos.y + 4, 4.5f);
        Line(pos.x + 11.25f, pos.y + 2, pos.x + 11.25f, pos.y + 4);
    }

    public void Animate()
    {
        if (check == false && namePos.y < 1f)
        {
            namePos.y += 3f * Time.deltaTime;
        }
        else if (namePos.y > -1.5f)
        {
            check = true;
            namePos.y -= 3f * Time.deltaTime;
        }
        else if (namePos.y < -1.5f)
        {
            check = false;
        }
    }
}