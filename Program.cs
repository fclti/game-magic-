using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;

namespace KERMFARZAN
{
    class Program
    {
     private static GameWindow MYGAMEWINDOS;
     static  int X1 = 0;
     static  int Y1 = 0;
     static int X2 = 0;
     static int Y2 = 0;
     static int Z1= 0 ;
     static int Z2 = 0;
     static int a;
        static void Main(string[] args)
        {
            MYGAMEWINDOS = new GameWindow(800,800);
            MYGAMEWINDOS.Load += new EventHandler<EventArgs>(MYGAMEWINDOS_Load);
            MYGAMEWINDOS.RenderFrame += new EventHandler<FrameEventArgs>(MYGAMEWINDOS_RenderFrame);
            MYGAMEWINDOS.UpdateFrame += new EventHandler<FrameEventArgs>(MYGAMEWINDOS_UpdateFrame);
            MYGAMEWINDOS.Run(60);
        }

        static void MYGAMEWINDOS_UpdateFrame(object sender, FrameEventArgs e)
        {

            var keyfarzan = Keyboard.GetState();
            if (keyfarzan[Key.A])
            {
                X1--;
            }
            if (keyfarzan[Key.D])
            {
                X1++;
            }
            if (keyfarzan[Key.S])
            {
                Y1--;
            }
            if (keyfarzan[Key.W])
            {
                Y1++;
            }
            if (keyfarzan[Key.E])
            {
                X2++;
            }
            if (keyfarzan[Key.R])
            {
                Y2++;
            }

            if (keyfarzan[Key.C])
            {
                X2--;
            }
            if (keyfarzan[Key.V])
            {
                Y2--;
            }
            if (keyfarzan[Key.Escape])
            {
                MYGAMEWINDOS.Exit();
                 Console.WriteLine("*******************************************");
                Console.Write("SCORE=");
                a = (+X1) + (+X2) + (+Y1) + (+Y2);
                Console.WriteLine(a);
                {
                    if (a >= 1000)
                    {
                        Console.WriteLine("*******************************************");
                        Console.WriteLine("BARANDEH SHODID");
                    }
                    else
                        if (a < 1000)
                        {
                            Console.WriteLine("*******************************************");
                            Console.WriteLine("BAKHTID");
                        }
                }
                Console.WriteLine("*******************************************");
                Console.ReadLine();
            }
            if (keyfarzan[Key.F2])
            {
                X1 = Y1 = Z1 = Z2 = Y2 = X2 = 0;
                Console.WriteLine("*******************************************");
                Console.Write("RESETGAME");
                Console.ReadLine();
            }
            if (keyfarzan[Key.P])
            {
                X1 = X2;Y1=Y2;Z1=Z2;
                Console.WriteLine("*******************************************");
                Console.Write("gharineh nesbat be mosalase 2");
                Console.ReadLine();
            }
            if (keyfarzan[Key.O])
            {
                X2 = X1; Y2 = Y1; Z2 = Z1;
                Console.WriteLine("*******************************************");
                Console.Write("gharineh nesbat be mosalase 1");
                Console.ReadLine();
            }
            if (keyfarzan[Key.F1])
            {
                Console.WriteLine("*******************************************");
                Console.WriteLine("*************(ALL KEY GAME )***************");
                Console.WriteLine("*******************************************");
                Console.Write("W==");
                Console.WriteLine("Y1++");
                Console.WriteLine("*******************************************");
                Console.Write("S==");
                Console.WriteLine("Y1--");
                Console.WriteLine("*******************************************");
                Console.Write("D==");
                Console.WriteLine("X1++");
                Console.WriteLine("*******************************************");
                Console.Write("E==");
                Console.WriteLine("X2++");
                Console.WriteLine("*******************************************");
                Console.Write("R==");
                Console.WriteLine("Y2++");
                Console.WriteLine("*******************************************");
                Console.Write("C==");
                Console.WriteLine("X2--");
                Console.WriteLine("*******************************************");
                Console.Write("V==");
                Console.WriteLine("Y2--");
                Console.WriteLine("*******************************************");
                Console.Write("A==");
                Console.WriteLine("X1--");
                Console.WriteLine("*******************************************");
                Console.Write("Esc==");
                Console.WriteLine("EXIT");
                Console.WriteLine("*******************************************");
                Console.Write("F2==");
                Console.WriteLine("RESTGAME");
                Console.WriteLine("*******************************************");
                Console.Write("F1==");
                Console.WriteLine("HELP GAME");
                Console.WriteLine("*******************************************");
                Console.Write("F12==");
                Console.WriteLine("ABOUT GAME");
                Console.WriteLine("*******************************************");
                Console.WriteLine("******CODE MAKHFI GAME BARAY KOMAK*********");
                Console.WriteLine("*******************************************");
                Console.Write("O==");
                Console.WriteLine("gharineh nesbat be mosalase 1");
                Console.WriteLine("*******************************************");
                Console.Write("P==");
                Console.WriteLine("gharineh nesbat be mosalase 2");
                Console.WriteLine("*******************************************");
                Console.ReadLine();
            }
            if (keyfarzan[Key.F12])
            {
                Console.WriteLine("*******************************************");
                Console.WriteLine("****************ABOUT GAME*****************");
                Console.WriteLine("*******************************************");
                Console.WriteLine("        TARAH GAME :FARZAN OLYAEIAN        ");
                Console.WriteLine("*******************************************");
                Console.WriteLine("         GAME NAME : Magic triangles       ");
                Console.WriteLine("*******************************************");
                Console.ReadLine();
            }
            }

        static void MYGAMEWINDOS_RenderFrame(object sender, FrameEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.LoadIdentity();
            GL.Ortho(-500, 500, -500, 500, -1, 1);
            GL.PopMatrix();
            GL.Begin(PrimitiveType.LineLoop);
            GL.Color4(Color4.Cyan);
            GL.Vertex2(X1,Y1);
            GL.Vertex2(X2,Y2);
            GL.Vertex2(Z1, Z2);
            GL.End();
            GL.PushMatrix();
            GL.PopMatrix();
            GL.Begin(PrimitiveType.LineLoop);
            GL.Color4(Color4.Red);
            GL.Vertex2(X2, Y1);
            GL.Vertex2(X1, Y2);
            GL.Vertex2(Z2, Z1);
            GL.End();
            GL.PushMatrix();
            GL.PushMatrix();
            GL.Begin(PrimitiveType.TriangleFan);
            GL.Color4(Color4.ForestGreen);
            GL.Vertex2(Z1, Z2);
            GL.Vertex2(-X2,-Y1);
            GL.Vertex2(X1,-Y2);
            GL.Vertex2(-X1,-Y2);
            GL.End();
            GL.PopMatrix();
            Console.Write("x1==");
            Console.WriteLine(X1);
            Console.Write("y1==");
            Console.WriteLine(Y1);
            Console.Write("x2==");
            Console.WriteLine(X2);
            Console.Write("y2==");
            Console.WriteLine(Y2);
            Console.Write("z1==");
            Console.WriteLine(Z1);
            Console.Write("z2==");
            Console.WriteLine(Z2);
            MYGAMEWINDOS.SwapBuffers();
        }

        static void MYGAMEWINDOS_Load(object sender, EventArgs e)
        {
            Console.WriteLine("***********************************************************");
            Console.WriteLine("                 be  name khoda                            ");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("                       HI                                  ");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("           GAME NAME = Magic triangles                     ");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("                   Please  ENTER                           ");
            Console.WriteLine("***********************************************************");
            Console.ReadLine();

        }
    }
}
