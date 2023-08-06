using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace largegame
{
    public partial class Form1 : Form
    {


        public class CActor
        {
            //public int X, Y;
            public Rectangle rcDst;
            public Rectangle rcSrc;
            // public Bitmap img;
            public List<Bitmap> imgs = new List<Bitmap>();
            public int iCurrFrame = 0;
            public int HEALTH = 300;
            public int firediect = 0;
            public int zomdiee = 0;
            public int helli = 0;
            public int hellifire = 0;
            public int ltime = 0;
            public int tankdig = 0;
            public int anmitetankbull = 0;
            public int bullct = 0;
            public int grtkiiled = 0;
            public int fstdie = 0;
            public int secdie = 0;
            public int thrddie = 0;
            public int forthdie = 0;
            public int rideflage = 0;








            public int bulctmove;

        }
        public class Cbou
        {
            //public int X, Y;
            public Rectangle rcDst;
            public Rectangle rcSrc;
            public Bitmap img;
        }
        Bitmap BK = new Bitmap("21.bmp");
        CActor pnn300 = new CActor();
        CActor elev = new CActor();
        CActor pnn100 = new CActor();
        CActor pnn50 = new CActor();
        CActor pnnd0 = new CActor();
        CActor pnnd77 = new CActor();
        CActor pnnheli = new CActor();

        CActor pnndm1 = new CActor();
        Cbou pnn69 = new Cbou();
        Cbou pnnT = new Cbou();
        CActor zom = new CActor();
        CActor pnnf = new CActor();
        CActor pnnfireon = new CActor();
        CActor pnnlaz = new CActor();
        CActor pnnm1 = new CActor();
        CActor grou2 = new CActor();
        List<CActor> lground2 = new List<CActor>();
        CActor wall2 = new CActor();
        List<CActor> lwall2 = new List<CActor>();
        CActor lader = new CActor();
        CActor pnntank = new CActor();
        CActor pnnspaceship = new CActor();

        List<CActor> ltank = new List<CActor>();
        CActor pnnboom = new CActor();

        List<CActor> ltankbull = new List<CActor>();
        CActor pnntanbull = new CActor();

        CActor pnnhelifire = new CActor();
        List<CActor> lhelifire = new List<CActor>();

        List<CActor> llader = new List<CActor>();

        int ctdigtankf = 0;
        int flagfireon = 0;
        int hh = 1;
        public int ww = 0;
        //int[] ww = new int[100];
        List<CActor> ldoor = new List<CActor>();
        List<CActor> lmap1 = new List<CActor>();
        List<CActor> lboom = new List<CActor>();

        List<CActor> lwall = new List<CActor>();
        List<CActor> ltopwall = new List<CActor>();
        List<CActor> lfire = new List<CActor>();
        Bitmap off;
        int flagnewmap1;
        int ctw = 0;
        List<CActor> lspaceship = new List<CActor>();

        List<CActor> llazer = new List<CActor>();

        int[] firemanflagct = new int[100];
        int[] firemanbullets = new int[100];
        int[] firemanmovemove = new int[100];
        int[] ctt = new int[100];
        int ee = 0;
        int theend = 0;
        int slashj1ct = 0;
        int slashjairct = 0;
        int map2start = 0;
        int slashj2ct = 0;
        int[] flagct = new int[100];
        int[] bullets = new int[100];
        int[] move = new int[100];
        int ff = 0;
        int trap1ct = 0;
        int doorct = 0;
        Cbou pnnh = new Cbou();

        List<Cbou> Lbou = new List<Cbou>();

        List<Cbou> Ltrap = new List<Cbou>();
        List<CActor> lfireon = new List<CActor>();
        List<CActor> lheli = new List<CActor>();


        List<Cbou> lhealth = new List<Cbou>();

        int plaer1health;
        int p1 = 1;
        int tankride = 0;
        int tankNride = 0;



        List<CActor> Lfireman = new List<CActor>();
        List<CActor> lbull = new List<CActor>();
        CActor PNNB = new CActor();

        Timer tt = new Timer();
        List<CActor> Lzombies = new List<CActor>();
        int enmhit = 0;
        List<CActor> LActs = new List<CActor>();
        List<CActor> lground = new List<CActor>();
        List<CActor> lelev = new List<CActor>();
        List<CActor> lkey = new List<CActor>();
        CActor grou = new CActor();
        int ctofjump = 0;
        int lactsofjump = 0;
        int qq = 0;
        int flagkey = 0;
        int flag1 = 0;
        int dy;
        int iWhich = -1;
        bool drag;
        int jumpslash;
        int airslash;
        public int h = 0;
        int jumpslash2;
        int getn = 0;
        int dx;
        int flipjump;
        int BULLLCT = 0;
        int ctti = 0;
        int cttiheli = 0;

        int btclick = 0;
        int currx;
        int curry;
        int elvcct;
        int flipct;
        int lstart;

        public Form1()
        {
            ///*InitializeComponent*/();
            this.WindowState = FormWindowState.Maximized;
            this.Paint += new PaintEventHandler(Form1_Paint);
            this.Load += new EventHandler(Form1_Load);
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            tt.Start();
            tt.Interval = 10;
            tt.Tick += Tt_Tick;
            this.MouseUp += Form1_MouseUp;
            this.MouseMove += Form1_MouseMove;

            this.MouseDown += Form1_MouseDown;
        }


        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag == true)
            {
                //if (iWhich != -1)
                //{

                //    currx = e.X;
                //    curry = e.Y;
                //    dx = currx - dx;
                //    dy = curry - dy;


                //    Lbou[iWhich].img = new Bitmap("b2.bmp");


                //    dx = currx;
                //    dy = curry;

                //}

            }
            //DrawDubb(CreateGraphics());
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
            iWhich = -1;
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (btclick == 0)
            {
                drag = true;
                dx = e.X;
                dy = e.Y;
                iWhich = -1;
                for (int i = 0; i < Lbou.Count; i++)
                {
                    if (e.X > Lbou[i].rcDst.X && e.X < Lbou[i].rcDst.X + Lbou[i].img.Width && e.Y > Lbou[i].rcDst.Y && e.Y < Lbou[i].rcDst.Y + Lbou[i].img.Height)
                    {
                        iWhich = i;
                        //ct  = 1;
                        btclick = 1;
                        // flag[i] = 1;
                        break;
                    }

                }
                if (iWhich != -1)
                {

                    currx = e.X;
                    curry = e.Y;
                    dx = currx - dx;
                    dy = curry - dy;


                    Lbou[iWhich].img = new Bitmap("b2.bmp");


                    dx = currx;
                    dy = curry;

                }
            }
        }



        void movebullet()
        {
            for (int i = 0; i < lfire.Count; i++)
            {
                lfire[i].rcDst.X += 20;
                for (int b = 0; b < Lzombies.Count; b++)
                {
                    if (Lzombies[b].rcDst.X < lfire[i].rcDst.X + lfire[i].rcDst.Width && Lzombies[b].rcDst.X + Lzombies[b].rcDst.Width > lfire[i].rcDst.X + lfire[i].rcDst.Width)
                    {
                        //Lzombies[b].flag = 1;
                        lfire.RemoveAt(i);
                        break;
                    }

                }

            }
        }


      





        void createheli()
        {
            off = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);

            Random RR = new Random();

            int X, Y;
            int j = 0;
            for (int i = 0; i < 2; i++)
            {


                pnnheli = new CActor();
                //    pnn.X = RR.Next(100, this.Width);
                pnnheli.rcSrc = new Rectangle(0, 0, 600/*pnn.imgs.Width*/, 600/*pnn.imgs.Height*/);
                X = 1600+j;
                Y = 120;
                pnnheli.rcDst = new Rectangle(X, Y, 1000, 1000);

                // pnn.Y = RR.Next(100, this.Height);
                for (int k = 1; k < 8; k++)
                {
                    Bitmap img = new Bitmap(("helim" + k + ".bmp"));
                    Color clr = img.GetPixel(0, 0);
                    img.MakeTransparent(clr);
                    pnnheli.imgs.Add(img);
                }
                for (int k = 1; k < 6; k++)
                {
                    Bitmap img = new Bitmap(("helid" + k + ".bmp"));
                    Color clr = img.GetPixel(0, 0);
                    img.MakeTransparent(clr);
                    pnnheli.imgs.Add(img);
                }
                lheli.Add(pnnheli);
                j += 700;
            }

        }
        void createtank()
        {
            off = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);

            Random RR = new Random();

            int X, Y;

            pnntank = new CActor();
            //    pnn.X = RR.Next(100, this.Width);
            pnntank.rcSrc = new Rectangle(0, 0, 600/*pnn.imgs.Width*/, 600/*pnn.imgs.Height*/);
            X = 1680;
            Y = 600;
            pnntank.rcDst = new Rectangle(X, Y, 1000, 1000);

            // pnn.Y = RR.Next(100, this.Height);
            for (int k = 0; k < 1; k++)
            {
                Bitmap img = new Bitmap(("tankR" + "..bmp"));
                Color clr = img.GetPixel(0, 0);
                img.MakeTransparent(clr);
                pnntank.imgs.Add(img);
            }
            for (int k = 0; k < 1; k++)
            {
                Bitmap img = new Bitmap(("tankU" + ".bmp"));
                Color clr = img.GetPixel(0, 0);
                img.MakeTransparent(clr);
                pnntank.imgs.Add(img);
            }

            ltank.Add(pnntank);

        }

        void cBoomright()
        {
            off = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);

            Random RR = new Random();

            int X, Y;
            int j = 0;
            for (int i = 0; i < 8; i++)
            {


                pnnboom = new CActor();
                //    pnn.X = RR.Next(100, this.Width);
                pnnboom.rcSrc = new Rectangle(0, 0, 300/*pnn.imgs.Width*/, 280/*pnn.imgs.Height*/);
                X = 2300 + j;
                Y = 750;
                pnnboom.rcDst = new Rectangle(X, Y, 1000, 1000);

                // pnn.Y = RR.Next(100, this.Height);
                for (int k = 1; k < 20; k++)
                {
                    Bitmap img = new Bitmap(("lstenmrun" + k + ".bmp"));
                    Color clr = img.GetPixel(0, 0);
                    img.MakeTransparent(clr);
                    pnnboom.imgs.Add(img);
                }
                for (int k = 10; k < 13; k++)
                {
                    Bitmap img = new Bitmap(("lstenmfight" + k + ".bmp"));
                    Color clr = img.GetPixel(0, 0);
                    img.MakeTransparent(clr);
                    pnnboom.imgs.Add(img);
                }
                for (int k = 1; k < 12; k++)
                {
                    Bitmap img = new Bitmap(("lstenmgetlaser" + k + ".bmp"));
                    Color clr = img.GetPixel(0, 0);
                    img.MakeTransparent(clr);
                    pnnboom.imgs.Add(img);
                }
                for (int k = 1; k < 14; k++)
                {
                    Bitmap img = new Bitmap(("lstenmnorhit" + k + ".bmp"));
                    Color clr = img.GetPixel(0, 0);
                    img.MakeTransparent(clr);
                    pnnboom.imgs.Add(img);
                }
                for (int k = 1; k < 11; k++)
                {
                    Bitmap img = new Bitmap(("lstenmgethittruk" + k + ".bmp"));
                    Color clr = img.GetPixel(0, 0);
                    img.MakeTransparent(clr);
                    pnnboom.imgs.Add(img);
                }
                for (int k = 1; k < 21; k++)
                {
                    Bitmap img = new Bitmap(("lstenmgetfire" + k + ".bmp"));
                    Color clr = img.GetPixel(0, 0);
                    img.MakeTransparent(clr);
                    pnnboom.imgs.Add(img);
                }
                lboom.Add(pnnboom);
                j += 200;
            }



        }
        void cBoomup()
        {
            off = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);

            Random RR = new Random();

            int X, Y;
            int j = 0;
            for (int i = 0; i < 3; i++)
            {


                pnnboom = new CActor();
                //    pnn.X = RR.Next(100, this.Width);
                pnnboom.rcSrc = new Rectangle(0, 0, 300/*pnn.imgs.Width*/, 280/*pnn.imgs.Height*/);
                X = 1000 + j;
                Y = 400;
                pnnboom.rcDst = new Rectangle(X, Y, 1000, 1000);

                // pnn.Y = RR.Next(100, this.Height);
                for (int k = 1; k < 20; k++)
                {
                    Bitmap img = new Bitmap(("lstenmrun" + k + ".bmp"));
                    Color clr = img.GetPixel(0, 0);
                    img.MakeTransparent(clr);
                    pnnboom.imgs.Add(img);
                }
                for (int k = 10; k < 13; k++)
                {
                    Bitmap img = new Bitmap(("lstenmfight" + k + ".bmp"));
                    Color clr = img.GetPixel(0, 0);
                    img.MakeTransparent(clr);
                    pnnboom.imgs.Add(img);
                }
                for (int k = 1; k < 12; k++)
                {
                    Bitmap img = new Bitmap(("lstenmgetlaser" + k + ".bmp"));
                    Color clr = img.GetPixel(0, 0);
                    img.MakeTransparent(clr);
                    pnnboom.imgs.Add(img);
                }
                for (int k = 1; k < 14; k++)
                {
                    Bitmap img = new Bitmap(("lstenmnorhit" + k + ".bmp"));
                    Color clr = img.GetPixel(0, 0);
                    img.MakeTransparent(clr);
                    pnnboom.imgs.Add(img);
                }
                for (int k = 1; k < 11; k++)
                {
                    Bitmap img = new Bitmap(("lstenmgethittruk" + k + ".bmp"));
                    Color clr = img.GetPixel(0, 0);
                    img.MakeTransparent(clr);
                    pnnboom.imgs.Add(img);
                }
                for (int k = 1; k < 21; k++)
                {
                    Bitmap img = new Bitmap(("lstenmgetfire" + k + ".bmp"));
                    Color clr = img.GetPixel(0, 0);
                    img.MakeTransparent(clr);
                    pnnboom.imgs.Add(img);
                }
                lboom.Add(pnnboom);
                j += 200;
            }



        }

        void cBoom()
        {
            off = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);

            Random RR = new Random();

            int X, Y;
            int j = 0;
            for (int i = 0; i < 3; i++)
            {


                pnnboom = new CActor();
                //    pnn.X = RR.Next(100, this.Width);
                pnnboom.rcSrc = new Rectangle(0, 0, 300/*pnn.imgs.Width*/, 280/*pnn.imgs.Height*/);
                X = 500+j;
                Y = 750;
                pnnboom.rcDst = new Rectangle(X, Y, 1000, 1000);

                // pnn.Y = RR.Next(100, this.Height);
                for (int k = 1; k < 20; k++)
                {
                    Bitmap img = new Bitmap(("lstenmrun" + k + ".bmp"));
                    Color clr = img.GetPixel(0, 0);
                    img.MakeTransparent(clr);
                    pnnboom.imgs.Add(img);
                }
                for (int k = 10; k < 13; k++)
                {
                    Bitmap img = new Bitmap(("lstenmfight" + k + ".bmp"));
                    Color clr = img.GetPixel(0, 0);
                    img.MakeTransparent(clr);
                    pnnboom.imgs.Add(img);
                }
                for (int k = 1; k < 12; k++)
                {
                    Bitmap img = new Bitmap(("lstenmgetlaser" + k + ".bmp"));
                    Color clr = img.GetPixel(0, 0);
                    img.MakeTransparent(clr);
                    pnnboom.imgs.Add(img);
                }
                for (int k = 1; k < 14; k++)
                {
                    Bitmap img = new Bitmap(("lstenmnorhit" + k + ".bmp"));
                    Color clr = img.GetPixel(0, 0);
                    img.MakeTransparent(clr);
                    pnnboom.imgs.Add(img);
                }
                for (int k = 1; k < 11; k++)
                {
                    Bitmap img = new Bitmap(("lstenmgethittruk" + k + ".bmp"));
                    Color clr = img.GetPixel(0, 0);
                    img.MakeTransparent(clr);
                    pnnboom.imgs.Add(img);
                }
                for (int k = 1; k < 21; k++)
                {
                    Bitmap img = new Bitmap(("lstenmgetfire" + k + ".bmp"));
                    Color clr = img.GetPixel(0, 0);
                    img.MakeTransparent(clr);
                    pnnboom.imgs.Add(img);
                }
            lboom.Add(pnnboom);
                j += 100;
            }


            
        }
        void cenememove()
        {
            for (int i = 0; i < lboom.Count; i++)
            {
                if(tankride==1)
                {
                    if (lboom[i].rcDst.X >= ltank[0].rcDst.X - 600 && lboom[i].rcDst.X <= ltank[0].rcDst.X + 600 && lboom[i].rcDst.Y > ltank[0].rcDst.Y - 300 && lboom[i].rcDst.Y < ltank[0].rcDst.Y + 300&&lboom[i].thrddie == 0)
                    {





                        if (lboom[i].hellifire == 0)
                        {
                            lboom[i].iCurrFrame = 19;
                            lboom[i].hellifire = 1;
                        }
                        else
                        {
                            lboom[i].iCurrFrame++;
                            if (lboom[i].iCurrFrame >= 21)
                            {
                                lboom[i].iCurrFrame = 0;
                                lboom[i].hellifire = 0;
                            }
                        }





                    }
                    else if (lboom[i].rcDst.X >= LActs[0].rcDst.X && lboom[i].rcDst.X <= LActs[0].rcDst.X + 1000 && lboom[i].rcDst.Y > LActs[0].rcDst.Y - 200 && lboom[i].rcDst.Y < LActs[0].rcDst.Y + 200&& lboom[i].thrddie == 0 && lboom[i].forthdie == 0)
                    {
                        if (lboom[i].hellifire == 0)
                        {
                            lboom[i].iCurrFrame = 0;
                            lboom[i].hellifire = 1;
                        }
                        lboom[i].rcDst.X -= 20;
                        lboom[i].iCurrFrame++;
                        if (lboom[i].iCurrFrame >= 18)
                        {
                            lboom[i].iCurrFrame = 0;
                        }

                    }

                }
                else if (lboom[i].fstdie == 0&& lboom[i].secdie == 0&& lboom[i].thrddie == 0 && lboom[i].forthdie == 0)
                {


                    if (lboom[i].rcDst.X >= LActs[0].rcDst.X - 100 && lboom[i].rcDst.X <= LActs[0].rcDst.X + 100 && lboom[i].rcDst.Y > LActs[0].rcDst.Y - 100 && lboom[i].rcDst.Y < LActs[0].rcDst.Y + 100)
                    {





                        if (lboom[i].hellifire == 0)
                        {
                            lboom[i].iCurrFrame = 19;
                            lboom[i].hellifire = 1;
                        }
                        else
                        {
                            lboom[i].iCurrFrame++;
                            if (lboom[i].iCurrFrame >= 21)
                            {
                                ISHIT();
                                lboom[i].iCurrFrame = 0;
                                lboom[i].hellifire = 0;
                            }
                        }
                           

                        
                              

                    }


                    else if (lboom[i].rcDst.X >= LActs[0].rcDst.X && lboom[i].rcDst.X <= LActs[0].rcDst.X + 1000 && lboom[i].rcDst.Y > LActs[0].rcDst.Y - 200 && lboom[i].rcDst.Y < LActs[0].rcDst.Y + 200)
                    {
                        if (lboom[i].hellifire == 0)
                        {
                            lboom[i].iCurrFrame = 0;
                            lboom[i].hellifire = 1;
                        }
                            lboom[i].rcDst.X -= 20;
                        lboom[i].iCurrFrame++;
                        if (lboom[i].iCurrFrame >=18 )
                        {
                            lboom[i].iCurrFrame = 0;
                        }

                    }

                    if (lboom[i].rcDst.X <= LActs[0].rcDst.X - 40 && lboom[i].rcDst.Y > LActs[0].rcDst.Y - 200 && lboom[i].rcDst.Y < LActs[0].rcDst.Y + 200)
                        lboom[i].rcDst.X += 20;
                }
            }
        }

        void tankaifire(int i)
        {



            int X, Y;

            pnnhelifire = new CActor();

            pnnhelifire.rcSrc = new Rectangle(0, 0, 800/*pnn.imgs.Width*/, 800/*pnn.imgs.Height*/);
            X = lheli[i].rcDst.X + 30;
            Y = lheli[i].rcDst.Y + 60;
            pnnhelifire.rcDst = new Rectangle(X, Y, 800, 800);

            Bitmap img = new Bitmap("helifire" + ".bmp");
            Color clr = img.GetPixel(0, 0);
            img.MakeTransparent(clr);
            pnnhelifire.imgs.Add(img);

            lhelifire.Add(pnnhelifire);
            if (ff == 10)
            {

            }
            //  DrawDubb(this.CreateGraphics());



        }
        void tankMOVEbulL()
        {
            for (int Q = 0; Q < ltankbull.Count; Q++)
            {
                //int dd = 0;
                int flagis = 0;



                        if (ltankbull[Q].bulctmove == 0)
                        {
                    if (ltankbull[Q].tankdig < 5)
                    {
                        ltankbull[Q].rcDst.X += 30;
                        ltankbull[Q].rcDst.Y -= 10;
                        ltankbull[Q].tankdig++;
                    }
                    if (ltankbull[Q].tankdig > 4)
                    {
                        ltankbull[Q].rcDst.X += 20;
                        ltankbull[Q].rcDst.Y += 40;
                        ltankbull[Q].tankdig++;

                    }

                }
                if (ltankbull[Q].bulctmove == 1)
                {


                    ltankbull[Q].rcDst.Y -= 20;
                    
                    

                }

                //ltankbull[Q].bulctmove++;
                for (int i = 0; i < lheli.Count; i++)
                {
                    if (lheli[i].rcDst.X >= ltankbull[Q].rcDst.X - 300 && lheli[i].rcDst.X <= ltankbull[Q].rcDst.X + 200 && ltankbull[Q].rcDst.Y < lheli[i].rcDst.Y + 130)
                    {
                        if (ltankbull[Q].bulctmove == 1)
                        {
                            //cBoom(Q);
                        }

                        ltankbull[Q].bulctmove = 2;


                        if (ltankbull[Q].bulctmove > 1)
                        {

                            ltankbull[Q].anmitetankbull++;

                            if (ltankbull[Q].anmitetankbull == 1)
                            {
                                ltankbull[Q].iCurrFrame = 1;
                                ////LActs[0].rcDst.Y -= 60;

                            }
                            else
                            {

                                ltankbull[Q].iCurrFrame++;

                                if (6 < ltankbull[Q].iCurrFrame)
                                {

                                    //LActs[0].rcDst.X += 60;
                                    flagis = 1;
                                    //lboom.RemoveAt(Q);
                                    ltankbull.RemoveAt(Q);
                                    //LActs[0].rcDst.Y -= 10;

                                }
                            }


                        }

                      
                    }

                }
                if (flagis == 0)
                {
                    if (ltankbull[Q].rcDst.Y > lground2[0].rcDst.Y - 80 || ltankbull[Q].rcDst.Y < 40)
                    {
                        if (ltankbull[Q].bulctmove == 1)
                        {
                            //cBoom(Q);
                        }

                        ltankbull[Q].bulctmove = 2;


                        if (ltankbull[Q].bulctmove > 1)
                        {

                            ltankbull[Q].anmitetankbull++;

                            if (ltankbull[Q].anmitetankbull == 1)
                            {
                                ltankbull[Q].iCurrFrame = 1;
                                ////LActs[0].rcDst.Y -= 60;

                            }
                            else
                            {

                                ltankbull[Q].iCurrFrame++;

                                if (6 < ltankbull[Q].iCurrFrame)
                                {

                                    //LActs[0].rcDst.X += 60;

                                    //lboom.RemoveAt(Q);
                                    ltankbull.RemoveAt(Q);
                                    //LActs[0].rcDst.Y -= 10;

                                }
                            }
                        }

                    }
                }




            }
        }
       
        void tankbULL()
        {


            int X, Y;

            pnntanbull = new CActor();
            if (ltank[0].iCurrFrame == 0)
            {
                for (int k = 0; k < 1; k++)
                {
                    pnntanbull.rcSrc = new Rectangle(0, 0, 1100/*pnn.imgs.Width*/, 1100/*pnn.imgs.Height*/);
                    X = ltank[0].rcDst.X + 510;
                    Y = ltank[0].rcDst.Y;
                    pnntanbull.rcDst = new Rectangle(X, Y, 800, 800);
                    pnntanbull.bulctmove = 0;
                    Bitmap img = new Bitmap(("tankfire" + ".bmp"));
                    Color clr = img.GetPixel(0, 0);
                    img.MakeTransparent(clr);
                    pnntanbull.imgs.Add(img);
                }
            }
            if (ltank[0].iCurrFrame == 1)
            {
                for (int k = 0; k < 1; k++)
                {
                    pnntanbull.rcSrc = new Rectangle(0, 0, 1100/*pnn.imgs.Width*/, 1100/*pnn.imgs.Height*/);
                    X = ltank[0].rcDst.X + 300;
                    Y = ltank[0].rcDst.Y - 10;
                    pnntanbull.rcDst = new Rectangle(X, Y, 800, 800);
                    pnntanbull.bulctmove = 1;
                    //pnntanbull.iCurrFrame = 1;
                    //pnntanbull.iCurrFrame++;
                    Bitmap img = new Bitmap(("tankfire" + ".bmp"));
                    Color clr = img.GetPixel(0, 0);
                    img.MakeTransparent(clr);
                    pnntanbull.imgs.Add(img);
                }
            }
            for (int k = 1; k < 7; k++)
            {
                //pnntanbull.rcSrc = new Rectangle(0, 0, 1100/*pnn.imgs.Width*/, 1100/*pnn.imgs.Height*/);
                //X = ltank[0].rcDst.X + 300;
                //Y = ltank[0].rcDst.Y - 10;
                //pnntanbull.rcDst = new Rectangle(X, Y, 800, 800);
                //pnntanbull.bulctmove = 1;
                //pnntanbull.iCurrFrame = 1;
                //pnntanbull.iCurrFrame++;
                Bitmap img = new Bitmap(("tankboom" +k+ ".bmp"));
                Color clr = img.GetPixel(0, 0);
                img.MakeTransparent(clr);
                pnntanbull.imgs.Add(img);
            }



            //if (ltank[0].iCurrFrame == 0)
            //{
            //    pnntanbull.rcSrc = new Rectangle(0, 0, 1100/*pnn.imgs.Width*/, 1100/*pnn.imgs.Height*/);
            //    X = ltank[0].rcDst.X + 510;
            //    Y = ltank[0].rcDst.Y ;
            //    pnntanbull.rcDst = new Rectangle(X, Y, 800, 800);
            //    pnntanbull.iCurrFrame = 0;
            //    pnntanbull.iCurrFrame++;


            //}


            //Bitmap img = new Bitmap("tankfire" + ".bmp");
            //Color clr = img.GetPixel(0, 0);
            //img.MakeTransparent(clr);
            //pnntanbull.imgs.Add(img);


            ltankbull.Add(pnntanbull);
            
            if (ff == 10)
            {

            }
            //  DrawDubb(this.CreateGraphics());
           

        }
        void firetankmove()
        {
            for (int i = 0; i < ltank.Count; i++)
            {


                if (ltank[i].rcDst.X >= LActs[0].rcDst.X - 100 && lheli[i].rcDst.X <= LActs[0].rcDst.X + 80 && lheli[i].rcDst.Y > LActs[0].rcDst.Y - 1000 && lheli[i].rcDst.Y < LActs[0].rcDst.Y + 1000)
                {
                    //MessageBox.Show(1 + "");
                    //firemanflagct[flagfireon] = 1;
                    if (lheli[i].hellifire == 0)
                    {
                        if (cttiheli > 4)
                        {
                            //MessageBox.Show(1 + "");

                            cttiheli = 0;
                            heliaifire(i);
                        }
                        for (int r = 0; r < lhelifire.Count; r++)
                        {
                            lhelifire[r].rcDst.Y += 50;
                            lhelifire[r].ltime++;
                            if (lhelifire[r].rcDst.Y > LActs[0].rcDst.Y - 30 || lhelifire[r].ltime > 20)
                            {
                                lhelifire.RemoveAt(r);
                                //MessageBox.Show(1 + "");

                            }

                        }
                    }
                    else
                    {
                        for (int q = 0; q < lhelifire.Count; q++)
                        {
                            lhelifire.RemoveAt(q);
                        }
                    }
                }
            }
        }




        void moveheli()
        {
            for (int i = 0; i < lheli.Count; i++)
            {
                if (lheli[i].helli == 0)
                {


                    if (lheli[i].rcDst.X >= LActs[0].rcDst.X - 100 && lheli[i].rcDst.X <= LActs[0].rcDst.X + 100 && lheli[i].rcDst.Y > LActs[0].rcDst.Y - 180 && lheli[i].rcDst.Y < LActs[0].rcDst.Y + 180)
                    {
                      
                    }


                    else if (lheli[i].rcDst.X >= LActs[0].rcDst.X  && lheli[i].rcDst.X <= LActs[0].rcDst.X + 1000 && lheli[i].rcDst.Y > LActs[0].rcDst.Y - 1000 && lheli[i].rcDst.Y < LActs[0].rcDst.Y + 1000)
                    {
                        lheli[i].rcDst.X -= 20;
                        lheli[i].iCurrFrame++;
                        if (lheli[i].iCurrFrame >= 7)
                        {
                            lheli[i].iCurrFrame = 0;
                        }

                    }

                    if (lheli[i].rcDst.X <= LActs[0].rcDst.X - 40 && lheli[i].rcDst.Y > LActs[0].rcDst.Y - 500 && lheli[i].rcDst.Y < LActs[0].rcDst.Y + 500)
                        lheli[i].rcDst.X += 20;
                }
            }
        }


        void chechlaser()
        {
            if (lstart == 1)
            {
                lazer();
                lstart = 0;
            }
            else if (lstart == 0)
            {
                for (int i = 0; i < llazer.Count; i++)
                {
                    llazer.RemoveAt(i);
                }

            }
        }



        void lazer()
        {

            int X, Y;
            int j = 0; ;
            for (int i = 0; i < 30; i++)
            {
                pnnlaz = new CActor();

                pnnlaz.rcSrc = new Rectangle(0, 0, 1200/*pnn.imgs.Width*/, 1200/*pnn.imgs.Height*/);
                X = LActs[0].rcDst.X + 40 + j;
                Y = LActs[0].rcDst.Y;
                pnnlaz.rcDst = new Rectangle(X, Y, 800, 800);

                Bitmap img = new Bitmap("lazer" + ".bmp");
                Color clr = img.GetPixel(0, 0);
                img.MakeTransparent(clr);
                pnnlaz.imgs.Add(img);

                llazer.Add(pnnlaz);
                if (ff == 10)
                {

                }
                j += 10;
            }
                for (int i = 0; i < 30; i++)
                {
                    for (int q = 0; q < Lzombies.Count; q++)
                     {
                    if (llazer[i].rcDst.X >= Lzombies[q].rcDst.X - 100 && llazer[i].rcDst.X <= Lzombies[q].rcDst.X + 100 && llazer[i].rcDst.Y > Lzombies[q].rcDst.Y - 180 && llazer[i].rcDst.Y < Lzombies[q].rcDst.Y + 180)
                    {

                        if (Lzombies[q].zomdiee == 0)
                        {
                            //MessageBox.Show(1 + "");
                            Lzombies[q].zomdiee = 1;
                        }
                        //break/*;*/
                    }
                }
                for (int q = 0; q < Lfireman.Count; q++)
                {

                    if (llazer[i].rcDst.X >= Lfireman[q].rcDst.X - 100 && llazer[i].rcDst.X <= Lfireman[q].rcDst.X + 100 && llazer[i].rcDst.Y > Lfireman[q].rcDst.Y - 180 && llazer[i].rcDst.Y < Lfireman[q].rcDst.Y + 180)
                    {

                        if (Lfireman[q].firediect == 0)
                        {
                            Lfireman[q].firediect = 1;
                        }
                        //break;
                    }
                }

                for (int q = 0; q < lboom.Count; q++)
                {

                    if (llazer[i].rcDst.X >= lboom[q].rcDst.X - 100 && llazer[i].rcDst.X <= lboom[q].rcDst.X + 100 && llazer[i].rcDst.Y > lboom[q].rcDst.Y - 180 && llazer[i].rcDst.Y < lboom[q].rcDst.Y + 180)
                    {

                        if (lboom[q].fstdie == 0)
                        {
                            lboom[q].fstdie = 1;
                        }
                        //break;
                    }
                }
            }
        }
        void actorhitheli()
        {
            for (int i = 0; i < lheli.Count; i++)
            {
                if (lheli[i].rcDst.X >= LActs[0].rcDst.X-100 && lheli[i].rcDst.X <= LActs[0].rcDst.X + 80 && LActs[0].rcDst.Y < lheli[i].rcDst.Y+130 && airslash==1)
                {
                   lheli[i].hellifire = 1;
                                }


            for (int q = 0; q < ltankbull.Count; q++)
            {
                if (lheli[i].rcDst.X >= ltankbull[q].rcDst.X - 300 && lheli[i].rcDst.X <= ltankbull[q].rcDst.X + 200 && ltankbull[q].rcDst.Y < lheli[i].rcDst.Y + 130 )
                {
                    lheli[i].hellifire = 1;
                }


            }
                        }


        }
        void heligethit()
        {
            for (int i = 0; i < lheli.Count; i++)
            {
                if (lheli[i].hellifire > 0)
                {


                    if (lheli[i].hellifire == 1)
                    {
                    lheli[i].hellifire++;
                        lheli[i].iCurrFrame = 7;
                        //LActs[0].rcDst.Y -= 20;
                        //Lfireman[i].rcDst.Y += 20;
                        //Lfireman[i].firediect++;
                    }
                    else
                    {
                        lheli[i].hellifire++;
                        //Lfireman[i].firediect++;
                        lheli[i].iCurrFrame++;
                        //lheli[i].rcDst.Y += 10;
                        if (11 < lheli[i].iCurrFrame)
                        {
                            //Lfireman[i].rcDst.Y += 5;
                            //LActs[0].rcDst.Y += 60;
                            lheli.RemoveAt(i);
                            for (int q = 0; q < lhelifire.Count; q++)
                            {
                                lhelifire.RemoveAt(q);
                            }
                            //LActs[0].rcDst.Y += 60;
                        }


                    }

                }
            }

        }
        void checkenmies()
        {
            for (int i = 0; i < Lfireman.Count; i++)
            {
                if (Lfireman[i].firediect > 0)
                {



                    if (Lfireman[i].firediect == 1)
                    {
                        Lfireman[i].iCurrFrame = 2;
                        //LActs[0].rcDst.Y -= 20;
                        Lfireman[i].rcDst.Y += 20;
                        Lfireman[i].firediect++;
                    }
                    else
                    {

                        Lfireman[i].firediect++;
                        Lfireman[i].iCurrFrame++;
                        Lfireman[i].rcDst.Y += 10;
                        if (10 < Lfireman[i].iCurrFrame)
                        {
                            Lfireman[i].rcDst.Y += 5;
                            //LActs[0].rcDst.Y += 60;
                            Lfireman[i].grtkiiled=1;
                            Lfireman.RemoveAt(i);

                            for (int q = 0; q < lfireon.Count; q++)
                            {
                                lfireon.RemoveAt(q);
                            }
                            //LActs[0].rcDst.Y += 60;
                        }


                    }

                }
            }
            for (int i = 0; i < Lzombies.Count; i++)
            {
                if (Lzombies[i].zomdiee > 0)
                {


                    if (Lzombies[i].zomdiee == 1)
                    {

                        Lzombies[i].iCurrFrame = 7;
                        Lzombies[i].rcDst.Y += 20;
                        //LActs[0].rcDst.Y -= 20;
                        //LActs[0].rcDst.Y -= 60;
                        Lzombies[i].zomdiee++;
                    }
                    else
                    {
                        Lzombies[i].rcDst.Y += 10;

                        Lzombies[i].zomdiee++;
                        Lzombies[i].iCurrFrame++;

                        if (17 < Lzombies[i].iCurrFrame)
                        {

                            //LActs[0].rcDst.Y += 60;
                            Lzombies.RemoveAt(i);

                            //LActs[0].rcDst.Y += 60;
                        }


                    }

                }
            }
            for (int i = 0; i < lboom.Count; i++)
            {


                if (lboom[i].fstdie > 0)
                {



                    if (lboom[i].fstdie == 1)
                    {
                        lboom[i].iCurrFrame = 22;
                        //LActs[0].rcDst.Y -= 20;
                        lboom[i].fstdie++;
                    }
                    else
                    {

                        lboom[i].fstdie++;
                        lboom[i].iCurrFrame++;
                        
                        if (32 < lboom[i].iCurrFrame)
                        {
                            lboom[i].rcDst.Y += 5;
                            //LActs[0].rcDst.Y += 60;
                            lboom[i].grtkiiled = 1;
                            lboom.RemoveAt(i);
                            break;
                          
                        }


                    }

                }
                if (lboom[i].secdie > 0)
                {



                    if (lboom[i].secdie == 1)
                    {
                        lboom[i].iCurrFrame = 33;
                        //LActs[0].rcDst.Y -= 20;
                        lboom[i].secdie++;
                        
                    }
                    else
                    {

                        lboom[i].secdie++;
                        lboom[i].iCurrFrame++;
                        if (43 == lboom[i].iCurrFrame)
                        {
                            lboom[i].rcDst.Y += 50;

                        }

                        if (45 < lboom[i].iCurrFrame)
                        {
                            lboom[i].rcDst.Y += 50;
                            //LActs[0].rcDst.Y += 60;
                            lboom[i].grtkiiled = 1;
                            lboom.RemoveAt(i);
                            break;

                        }


                    }

                }
                if (lboom[i].thrddie > 0)
                {



                    if (lboom[i].thrddie == 1)
                    {
                        lboom[i].iCurrFrame = 60;
                        //LActs[0].rcDst.Y -= 20;
                        lboom[i].thrddie++;
                    }
                    else
                    {

                        lboom[i].thrddie++;
                        lboom[i].iCurrFrame++;
                        //if (43 == lboom[i].iCurrFrame)
                        //{
                        //    lboom[i].rcDst.Y += 50;

                        //}
                        if (67 == lboom[i].iCurrFrame)
                            lboom[i].iCurrFrame++;


                        if (72 < lboom[i].iCurrFrame)
                        {
                            //lboom[i].rcDst.Y += 50;
                            //LActs[0].rcDst.Y += 60;
                            lboom[i].grtkiiled = 1;
                            lboom.RemoveAt(i);
                            break;


                        }


                    }

                }
               

                
            }
































        }

        void firemangetfiremove()
        {
            for (int i = 0; i < Lfireman.Count; i++)
            {


                if (LActs[0].rcDst.X < Lfireman[i].rcDst.X + 200 && LActs[0].rcDst.X > Lfireman[i].rcDst.X - 600 && LActs[0].rcDst.Y < Lfireman[i].rcDst.Y + 60 && LActs[0].rcDst.Y > Lfireman[i].rcDst.Y - 60)
                {
                    //MessageBox.Show(1 + "");
                    //firemanflagct[flagfireon] = 1;
                    if (Lfireman[i].firediect == 0)
                    {
                        if (ctti > 3)
                        {
                            ctti = 0;
                            aifiremanfireon(i);
                        }
                        for (int r = 0; r < lfireon.Count; r++)
                        {
                            lfireon[r].rcDst.X -= 50;
                            if (lfireon[r].rcDst.X < LActs[0].rcDst.X + 30)
                            {
                                lfireon.RemoveAt(r);
                                ISHIT();
                                //MessageBox.Show(1 + "");

                            }

                        }
                    }
                    else
                    {
                        for (int q = 0; q < lfireon.Count; q++)
                        {
                            lfireon.RemoveAt(q);
                        }
                    }
                }
            }
        }
        private void Tt_Tick(object sender, EventArgs e)
        {


            chechlaser();
            movezomb();
            moveheli();
            cenememove();
            firemangetfiremove();
            firehelimove();
            actorhitheli();
            heligethit();
            //for (int i = 0 + ee; i < flagfireon; i++)
            //    {

            //        if (ctt[i] == 0)
            //        {
            //            //t++;

            //            aifiremanfireon();
            //            ctt[i]++;
            //        }
            //        else
            //        {


            //            lfireon[i].rcDst.X -= 50;
            //            //firemanmovemove[i] += 40;

            //        }
            //        //lfireon.RemoveAt(0);
            //        if (lfireon[i].rcDst.X <= LActs[0].rcDst.X + 60)
            //        {
            //            //lfireon.RemoveAt(i);
            //            //ee++;
            //            //flagfireon--;
            //            lfireon[i].rcDst.X -= 22220;

            //        }




            //    }






            //aifiremanfireon(0);


            if (trap1ct < 20)
            {
                trap1ct++;
            }
            if (trap1ct > 19)
            {
                pnnT.img = new Bitmap("trap1open.bmp");
                trap1ct++;

            }
            if (trap1ct > 40)
            {
                pnnT.img = new Bitmap("trap1.bmp");
                trap1ct = 0;

            }

            if (ctofjump != 1 || flipjump != 1)
            {
                grav();
            }


            if (flipjump == 1)
            {

                flipct++;


                if (flipct == 1)
                {
                    LActs[0].iCurrFrame = 16;
                    //LActs[0].rcDst.Y -= 10;

                }
                else
                {
                    if (LActs[0].iCurrFrame == 17 || LActs[0].iCurrFrame == 18 || LActs[0].iCurrFrame == 19)
                    {
                        LActs[0].rcDst.Y -= 40;
                        LActs[0].rcDst.X += 60;


                    }
                    LActs[0].iCurrFrame++;

                    if (20 < LActs[0].iCurrFrame)
                    {

                        LActs[0].rcDst.X += 60;
                        flipct = 0;
                        LActs[0].iCurrFrame = 0;
                        flipjump = 0;
                        //LActs[0].rcDst.Y -= 10;

                    }
                }
            }


            if (jumpslash == 1)
            {

               slashj1ct ++;


                if (slashj1ct == 1)
                {
                    LActs[0].iCurrFrame = 25;
                    LActs[0].rcDst.Y -= 60;

                }
                else
                {
                    if (LActs[0].iCurrFrame == 26 )
                    {
                        LActs[0].rcDst.Y -= 40;
                        //LActs[0].rcDst.X += 60;


                    }
                    LActs[0].iCurrFrame++;

                    if (29 < LActs[0].iCurrFrame)
                    {

                        //LActs[0].rcDst.X += 60;
                        slashj1ct = 0;
                        LActs[0].iCurrFrame = 0;
                        jumpslash = 0;
                        //LActs[0].rcDst.Y -= 10;

                    }
                }
            }



            if (jumpslash2 == 1)
            {

                slashj2ct++;


                if (slashj2ct == 1)
                {
                    LActs[0].iCurrFrame = 30;
                    //LActs[0].rcDst.Y -= 60;

                }
                else
                {
                    if (LActs[0].iCurrFrame == 31)
                    {
                        LActs[0].rcDst.Y -= 80;
                        //LActs[0].rcDst.X += 60;


                    }
                    LActs[0].iCurrFrame++;

                    if (35 < LActs[0].iCurrFrame)
                    {

                        //LActs[0].rcDst.X += 60;
                        slashj2ct = 0;
                        LActs[0].iCurrFrame = 0;
                        jumpslash2 = 0;
                        //LActs[0].rcDst.Y -= 10;

                    }
                }
            }




            if (airslash == 1)
            {

                slashjairct++;


                if (slashjairct == 1)
                {
                    LActs[0].iCurrFrame = 36;
                    //LActs[0].rcDst.Y -= 60;

                }
                else
                {
                    if (LActs[0].iCurrFrame == 38|| LActs[0].iCurrFrame == 39|| LActs[0].iCurrFrame == 40|| LActs[0].iCurrFrame == 41)
                    {
                        LActs[0].rcDst.Y -= 60;
                        //LActs[0].rcDst.X += 60;


                    }
                    LActs[0].iCurrFrame++;

                    if (43 < LActs[0].iCurrFrame)
                    {

                        //LActs[0].rcDst.X += 60;
                        slashjairct = 0;
                        LActs[0].iCurrFrame = 0;
                        airslash = 0;
                        //LActs[0].rcDst.Y -= 10;

                    }
                }
            }



            if (ctofjump == 1)
            {

                lactsofjump++;


                if (lactsofjump == 1)
                {
                    LActs[0].iCurrFrame = 9;
                    //LActs[0].rcDst.Y -= 10;

                }
                else
                {
                    if (LActs[0].iCurrFrame == 10 || LActs[0].iCurrFrame == 11)
                    {
                        LActs[0].rcDst.Y -= 40;
                    }
                    LActs[0].iCurrFrame++;

                    if (11 < LActs[0].iCurrFrame)
                    {
                        lactsofjump = 0;
                        LActs[0].iCurrFrame = 0;
                        ctofjump = 0;
                        //LActs[0].rcDst.Y -= 10;

                    }
                }
            }
            if (btclick == 0)
            {
                pnn69.img = new Bitmap("b1.bmp");

            }
            if (btclick == 1)
            {
                if (elvcct < 25)
                {

                    //if (lelev[0].rcDst.X >= 170)
                    //{


                    lelev[0].rcDst.X -= 30;
                    if (LActs[0].rcDst.Y <= lelev[0].rcDst.Y)
                    
                        {
                        LActs[0].rcDst.X -= 30;
                    }
                    elvcct++;
                    //}
                }

                if (elvcct > 24 && elvcct < 40)
                {


                    lelev[0].rcDst.Y += 30;
                    if (LActs[0].rcDst.Y <= lelev[0].rcDst.Y)
                    {
                        LActs[0].rcDst.Y += 30;
                    }
                    elvcct++;

                }

                if (elvcct > 59 && elvcct < 75)
                {

                    lelev[0].rcDst.Y -= 30;
                    if ( LActs[0].rcDst.Y <= lelev[0].rcDst.Y  )
                    {
                        LActs[0].rcDst.Y -= 30;
                    }
                    //LActs[0].rcDst.Y -= 30;
                    elvcct++;

                }
                if (elvcct > 74 && elvcct < 101)
                {

                    lelev[0].rcDst.X += 30;
                    if (LActs[0].rcDst.Y <= lelev[0].rcDst.Y)
                    {
                        
                        LActs[0].rcDst.X += 30;
                    }
                    elvcct++;

                }
                if (elvcct == 100)
                {
                    elvcct = 0;
                    btclick = 0;
                }

                if (elvcct > 39 && elvcct < 60)
                {
                    elvcct++;
                }


            }


            if (flagnewmap1 == 0)
            {
                for (int i = 0 + qq; i < ww; i++)
                {
                    if (flagct[i] == 1)
                    {
                        //t++;

                        fireon(i);










                        if (lfire[0].rcDst.X >= Lzombies[0].rcDst.X && lfire[0].rcDst.Y > Lzombies[0].rcDst.Y - 80 && lfire[0].rcDst.Y < Lzombies[0].rcDst.Y + 80 || bullets[i] >= 7)
                        {
                            //coma();
                            //ISHIT();

                            move[i] -= 8110;
                            //lfire.RemoveAt(0);
                            flagct[i] = 0;
                        }



                        //for (int b = 0; b < Lzombies.Count; b++)
                        //{
                        //    if (Lzombies[0].rcDst.X < lfire[i].rcDst.X + 30 && Lzombies[0].rcDst.X  > lfire[i].rcDst.X -30)
                        //    {
                        //        //Lzombies[b].flag = 1;
                        //        lfire.RemoveAt(0);
                        //        break;
                        //    }
                        //}

                        if (bullets[i] >= 6)
                        {

                            qq++;
                            move[i] += 8110;

                            flagct[i] = 0;
                            //ww++;
                        }
                        else
                        {

                            bullets[i]++;
                            move[i] += 80;
                            //lfire[i].rcDst.X += 20;
                        }
                        if (bullets[i] > 7)
                        {
                            move[i] += 8110;
                            flagct[i] = 0;
                            //lfire.RemoveAt(0);
                            //lfire[i].rcDst.X += 20;

                        }
                        else
                        {
                            //lfire[i].rcDst.X += 20;
                            DrawDubb(this.CreateGraphics());
                            //lfire[i].rcDst.X += 20;

                            lfire.RemoveAt(0);
                        }

                    }
                }
            }


            if (LActs[0].rcDst.X > lkey[0].rcDst.X - 60 && LActs[0].rcDst.X < lkey[0].rcDst.X + 80 && LActs[0].rcDst.Y > lkey[0].rcDst.Y - 80 && LActs[0].rcDst.Y < lkey[0].rcDst.Y + 80)
            {
                flagkey = 1;
                //MessageBox.Show(1 + "");
            }
            if (flagkey == 1)
            {
                if (hh <= 5)
                {
                    ldoor.RemoveAt(0);
                    int X, Y;

                    pnnd0 = new CActor();

                    pnnd0.rcSrc = new Rectangle(0, 0, 400/*pnn.imgs.Width*/, 900/*pnn.imgs.Height*/);
                    X = lground[9].rcDst.X;
                    Y = lground[9].rcDst.Y - 140;
                    pnnd0.rcDst = new Rectangle(X, Y, 400, 400);


                    Bitmap img = new Bitmap(("door" + hh + ".bmp"));
                    Color clr = img.GetPixel(0, 0);
                    img.MakeTransparent(clr);
                    pnnd0.imgs.Add(img);
                    ldoor.Add(pnnd0);
                    hh++;
                    doorct = 1;
                }

            }
            if (doorct == 1 && LActs[0].rcDst.X >= ldoor[0].rcDst.X && LActs[0].rcDst.Y >= ldoor[0].rcDst.Y - 20 && LActs[0].rcDst.X <= ldoor[0].rcDst.X + 20)
            {
                flagnewmap1 = 1;
            }
            MOVEbulL();
            tankMOVEbulL();
            if (BULLLCT == 2)
            {
                BULLLCT = 0;
            }
            BULLLCT++;
            if(flagnewmap1==1)
            { gravformap2(); }

            slashcheck();
            checkenmies();
            DrawDubb(this.CreateGraphics());

            ctti++;
            cttiheli++;
        }
        void trap1()
        {
            //Random RR = new Random();

            int X, Y;

            pnnT = new Cbou();
            //    pnn.X = RR.Next(100, this.Width);
            pnnT.rcSrc = new Rectangle(0, 0, 800/*pnn.imgs.Width*/, 690/*pnn.imgs.Height*/);
            X = lground[12].rcDst.X;
            Y = lground[9].rcDst.Y - 136;
            pnnT.rcDst = new Rectangle(X, Y, 1500, 800);

            // pnn.Y = RR.Next(100, this.Height);

            pnnT.img = new Bitmap("trap1.bmp");

            Ltrap.Add(pnnT);

        }


        void aifiremanfireon(int i)
        {


            int X, Y;

            pnnfireon = new CActor();

            pnnfireon.rcSrc = new Rectangle(0, 0, 400/*pnn.imgs.Width*/, 400/*pnn.imgs.Height*/);
            X = Lfireman[i].rcDst.X - 30;
            Y = Lfireman[i].rcDst.Y + 60;
            pnnfireon.rcDst = new Rectangle(X, Y, 800, 800);

            Bitmap img = new Bitmap("fireman3" + ".bmp");
            Color clr = img.GetPixel(0, 0);
            img.MakeTransparent(clr);
            pnnfireon.imgs.Add(img);

            lfireon.Add(pnnfireon);
            if (ff == 10)
            {

            }
            //  DrawDubb(this.CreateGraphics());


        }
        void heliaifire(int i)
        {
           


                int X, Y;

                pnnhelifire = new CActor();

            pnnhelifire.rcSrc = new Rectangle(0, 0, 800/*pnn.imgs.Width*/, 800/*pnn.imgs.Height*/);
                X = lheli[i].rcDst.X + 30;
                Y = lheli[i].rcDst.Y + 60;
            pnnhelifire.rcDst = new Rectangle(X, Y, 800, 800);

                Bitmap img = new Bitmap("helifire" + ".bmp");
                Color clr = img.GetPixel(0, 0);
                img.MakeTransparent(clr);
            pnnhelifire.imgs.Add(img);

                lhelifire.Add(pnnhelifire);
                if (ff == 10)
                {

                }
                //  DrawDubb(this.CreateGraphics());


            
        }

        void firehelimove()
        {
            for (int i = 0; i < lheli.Count; i++)
            {


                if (lheli[i].rcDst.X >= LActs[0].rcDst.X-100 && lheli[i].rcDst.X <= LActs[0].rcDst.X +80 && lheli[i].rcDst.Y > LActs[0].rcDst.Y - 1000 && lheli[i].rcDst.Y < LActs[0].rcDst.Y + 1000)
                {
                    //MessageBox.Show(1 + "");
                    //firemanflagct[flagfireon] = 1;
                    if (lheli[i].hellifire == 0)
                    {
                        if (cttiheli >4)
                        {
                            //MessageBox.Show(1 + "");

                            cttiheli = 0;
                            heliaifire(i);
                        }
                        for (int r = 0; r < lhelifire.Count; r++)
                        {
                            lhelifire[r].rcDst.Y += 50;
                            lhelifire[r].ltime++;
                            if (lhelifire[r].rcDst.Y > LActs[0].rcDst.Y - 30|| lhelifire[r].ltime>20)
                            { 
                                if (lhelifire[r].rcDst.Y > LActs[0].rcDst.Y - 30&&lhelifire[r].rcDst.X>=LActs[0].rcDst.X-80&& lhelifire[r].rcDst.X <= LActs[0].rcDst.X + 80)
                                {

                                    ISHIT();                                }
                                lhelifire.RemoveAt(r);

                            }

                        }
                    }
                    else
                    {
                        for (int q = 0; q < lhelifire.Count; q++)
                        {
                            lhelifire.RemoveAt(q);
                        }
                    }
                }
            }
        }



        void slashcheck()
        {

            for (int i = 0; i < lboom.Count; i++)
            {

                if (flagnewmap1 == 1 && LActs[0].rcDst.X >= lboom[i].rcDst.X - 100 && LActs[0].rcDst.X <= lboom[i].rcDst.X + 100 && LActs[0].rcDst.Y > lboom[i].rcDst.Y - 80 && LActs[0].rcDst.Y < lboom[i].rcDst.Y + 80&& jumpslash == 1   )
                {

                    if (lboom[i].secdie == 0)
                    {
                        lboom[i].secdie++;
                        //MessageBox.Show(1 + "");
                    }
                    break;

                }
                if (flagnewmap1 == 1 && LActs[0].rcDst.X >= lboom[i].rcDst.X - 100 && LActs[0].rcDst.X <= lboom[i].rcDst.X + 100 && LActs[0].rcDst.Y > lboom[i].rcDst.Y - 80 && LActs[0].rcDst.Y < lboom[i].rcDst.Y + 80 && jumpslash2 == 1)
                {

                    if (lboom[i].secdie == 0)
                    {
                        lboom[i].secdie++;
                        //MessageBox.Show(1 + "");
                    }
                    break;

                }
                if (flagnewmap1 == 1 && LActs[0].rcDst.X >= lboom[i].rcDst.X - 100 && LActs[0].rcDst.X <= lboom[i].rcDst.X + 100 && LActs[0].rcDst.Y > lboom[i].rcDst.Y - 80 && LActs[0].rcDst.Y < lboom[i].rcDst.Y + 80 && airslash == 1)
                {

                    if (lboom[i].secdie == 0)
                    {
                        lboom[i].secdie++;
                        //MessageBox.Show(1 + "");
                    }
                    break;

                }
                for (int Q = 0; Q < ltankbull.Count; Q++)
                {


                    if (flagnewmap1 == 1&&tankride==1 && ltankbull[Q].rcDst.X >= lboom[i].rcDst.X - 300 && ltankbull[Q].rcDst.X <= lboom[i].rcDst.X + 300 && ltankbull[Q].rcDst.Y > lboom[i].rcDst.Y - 80 && ltankbull[Q].rcDst.Y < lboom[i].rcDst.Y + 80)
                    {

                        if (lboom[i].thrddie == 0)
                        {
                            lboom[i].thrddie++;
                            ltankbull.RemoveAt(Q);
                            //MessageBox.Show(1 + "");
                        }
                        break;

                    }
                }

               

                  

            }
        }

            void MOVEbulL()
        {
            for (int Q = 0; Q < lbull.Count; Q++)
            {
                int dd = 0;
                lbull[Q].rcDst.X += 20;
                lbull[Q].bullct++;

                for (int i = 0; i < Lzombies.Count; i++)
                {
                    if (flagnewmap1 == 0 && lbull[Q].rcDst.X >= Lzombies[i].rcDst.X && lbull[Q].rcDst.X <= Lzombies[i].rcDst.X + 100 && lbull[Q].rcDst.Y > Lzombies[i].rcDst.Y - 180 && lbull[Q].rcDst.Y < Lzombies[i].rcDst.Y + 180)
                    {

                        if (Lzombies[i].zomdiee == 0)
                        {
                            Lzombies[i].zomdiee = 1;
                            dd = 1;

                            lbull.RemoveAt(Q);

                        }

                        break;
                    }
                   



                }
                if (dd == 0)
                {
                    for (int i = 0; i < Lfireman.Count; i++)
                    {

                        if (flagnewmap1 == 0 && lbull[Q].rcDst.X >= Lfireman[i].rcDst.X && lbull[Q].rcDst.X <= Lfireman[i].rcDst.X + 60 && lbull[Q].rcDst.Y > Lfireman[i].rcDst.Y - 180 && lbull[Q].rcDst.Y < Lfireman[i].rcDst.Y + 180)
                        {

                            if (lbull[Q].firediect == 0)
                            {
                                Lfireman[i].firediect++;
                                dd = 1;
                                lbull.RemoveAt(Q);
                            }
                            break;


                        }
                    }



                        for (int i = 0; i < lboom.Count; i++)
                        {

                            if (flagnewmap1 == 1 && lbull[Q].rcDst.X >= lboom[i].rcDst.X && lbull[Q].rcDst.X <= lboom[i].rcDst.X + 60 && lbull[Q].rcDst.Y > lboom[i].rcDst.Y - 180 && lbull[Q].rcDst.Y < lboom[i].rcDst.Y + 180)
                            {

                                if (lbull[Q].fstdie == 0)
                                {
                                    lboom[i].fstdie++;
                                    dd = 1;
                                    lbull.RemoveAt(Q);
                                }
                                break;

                            }

















                            //break;




                        }
                }
                if (dd == 0)
                {
                   
                  
                        for (int i = 0; i < lwall.Count; i++)
                        {
                            if (flagnewmap1==0&&lbull[Q].bulctmove == 40 || lbull[Q].rcDst.X >= ldoor[0].rcDst.X && lbull[Q].rcDst.X <= ldoor[0].rcDst.X + 60 && lbull[Q].rcDst.Y > ldoor[0].rcDst.Y - 80 && lbull[Q].rcDst.Y < ldoor[0].rcDst.Y + 80)
                            {
                                lbull.RemoveAt(Q);
                                break;
                            }
                            if (flagnewmap1 == 0 && lbull[Q].rcDst.X >= lwall[i].rcDst.X && lbull[Q].rcDst.X <= lwall[i].rcDst.X + 60 && lbull[Q].rcDst.Y > lwall[i].rcDst.Y - 50 && lbull[Q].rcDst.Y < lwall[i].rcDst.Y + 50)
                            {
                                lbull.RemoveAt(Q);
                                break;
                            }
                        }
                    for (int i = 0; i < lwall2.Count; i++)
                    {
                       
                        if (flagnewmap1 == 1 && lbull[Q].rcDst.X >= lwall2[i].rcDst.X && lbull[Q].rcDst.X <= lwall2[i].rcDst.X + 60 && lbull[Q].rcDst.Y > lwall2[i].rcDst.Y - 50 && lbull[Q].rcDst.Y < lwall2[i].rcDst.Y + 50)
                        {
                            lbull.RemoveAt(Q);
                            break;
                        }
                    }
                    

                }
            }
        }


        void bullcheck()
        {
            for (int Q = 0; Q < lbull.Count; Q++)
            {
                int dd = 0;

                for (int i = 0; i < Lzombies.Count; i++)
                {
                    if (lbull[Q].rcDst.X >= Lzombies[i].rcDst.X && lbull[Q].rcDst.X <= Lzombies[i].rcDst.X + 100 && lbull[Q].rcDst.Y > Lzombies[i].rcDst.Y - 180 && lbull[Q].rcDst.Y < Lzombies[i].rcDst.Y + 180)
                    {

                        if (Lzombies[i].zomdiee == 0)
                        {
                            Lzombies[i].zomdiee = 1;
                            dd = 1;

                            lbull.RemoveAt(Q);

                        }
                        break;
                    }
                    else
                    {
                        lbull[Q].rcDst.X += 20;
                        lbull[Q].bullct++;

                    }



                }
                if (dd == 0)
                {
                    for (int i = 0; i < Lfireman.Count; i++)
                    {
                        if (lbull[Q].rcDst.X >= Lfireman[i].rcDst.X && lbull[Q].rcDst.X <= Lfireman[i].rcDst.X + 60 && lbull[Q].rcDst.Y > Lfireman[i].rcDst.Y - 180 && lbull[Q].rcDst.Y < Lfireman[i].rcDst.Y + 180)
                        {

                            if (lbull[Q].firediect == 0)
                            {
                                Lfireman[i].firediect = 1;
                                dd = 1;
                                lbull.RemoveAt(Q);
                            }
                            //break;
                        }
                        else
                        {
                            lbull[Q].rcDst.X += 20;
                            lbull[Q].bulctmove++;
                        }
                        lbull[Q].bullct++;

                    }
                }
                if (dd == 0)
                {
                    if (lbull[Q].bullct > 20)
                    {
                        lbull.RemoveAt(Q);

                    }
                    else
                    {
                        lbull[Q].bullct++;
                        for (int i = 0; i < lwall.Count; i++)
                        {
                            if (lbull[Q].bulctmove == 40 || lbull[Q].rcDst.X >= ldoor[0].rcDst.X && lbull[Q].rcDst.X <= ldoor[0].rcDst.X + 60 && lbull[Q].rcDst.Y > ldoor[0].rcDst.Y - 80 && lbull[Q].rcDst.Y < ldoor[0].rcDst.Y + 80)
                            {
                                lbull.RemoveAt(Q);
                                break;
                            }
                            if (lbull[Q].rcDst.X >= lwall[i].rcDst.X && lbull[Q].rcDst.X <= lwall[i].rcDst.X + 60 && lbull[Q].rcDst.Y > lwall[i].rcDst.Y - 50 && lbull[Q].rcDst.Y < lwall[i].rcDst.Y + 50)
                            {
                                lbull.RemoveAt(Q);
                                break;
                            }
                        }
                    }

                }
            }
        }

        void bULL()
        {


            int X, Y;

            PNNB = new CActor();

            PNNB.rcSrc = new Rectangle(0, 0, 6000/*pnn.imgs.Width*/, 6000/*pnn.imgs.Height*/);
            X = LActs[0].rcDst.X + 30;
            Y = LActs[0].rcDst.Y + 20;
            PNNB.rcDst = new Rectangle(X, Y, 800, 800);

            Bitmap img = new Bitmap("BULL" + ".bmp");
            Color clr = img.GetPixel(0, 0);
            img.MakeTransparent(clr);
            PNNB.imgs.Add(img);
            LActs[0].iCurrFrame = 15;
            LActs[0].iCurrFrame = 0;

            lbull.Add(PNNB);
            if (ff == 10)
            {

            }
            //  DrawDubb(this.CreateGraphics());


        }


        void fireon(int i)
        {


            int X, Y;

            pnn300 = new CActor();

            pnn300.rcSrc = new Rectangle(0, 0, 400/*pnn.imgs.Width*/, 400/*pnn.imgs.Height*/);
            X = LActs[0].rcDst.X + 40 + move[i];
            Y = LActs[0].rcDst.Y - 100;
            pnn300.rcDst = new Rectangle(X, Y, 800, 800);

            Bitmap img = new Bitmap("fire" + bullets[i] + ".bmp");
            Color clr = img.GetPixel(0, 0);
            img.MakeTransparent(clr);
            pnn300.imgs.Add(img);

            lfire.Add(pnn300);
            if (ff == 10)
            {

            }
            //   DrawDubb(this.CreateGraphics());


        }
        void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int i;
            if (e.KeyCode == Keys.M && BULLLCT == 2)
            {
                bULL();
            }
            if (e.KeyCode == Keys.Z &&tankride==1)
            {
                tankbULL();
            }
            if (e.KeyCode == Keys.A)
            {
                ff = 0;

                if (flagnewmap1 == 1 && lmap1[0].rcDst.X < 0)
                {
                    lmap1[0].rcDst.X += 40;
                    ltank[0].rcDst.X += 40;


                    for (i = 0; i < lheli.Count; i++)
                    {

                        lheli[i].rcDst.X += 40;
                    }
                    for ( i = 0; i < lboom.Count; i++)
                    {

                        lboom[i].rcDst.X += 40;
                    }
                    for (i = 0; i < lground2.Count; i++)
                    {
                        lground2[i].rcDst.X += 40;
                    }
                    for (i = 0; i < lwall2.Count; i++)
                    {
                        lwall2[i].rcDst.X += 40;
                    }
                    llader[0].rcDst.X += 40;
                }
                for (i = 0; i < LActs.Count; i++)
                {

                    if (LActs[i].rcDst.X >= 0)
                        LActs[i].rcDst.X -= 20;


                    LActs[i].iCurrFrame++;
                    if (LActs[i].iCurrFrame >= 8)
                    {
                        LActs[i].iCurrFrame = 0;
                    }
                }
                grav();

            }
            if (e.KeyCode == Keys.J)
            {
                jumpslash = 1;
            }
            if (e.KeyCode == Keys.H)
            {
                jumpslash2 = 1;
            }
            if (e.KeyCode == Keys.G)
            {
                airslash = 1;
            }
            //if (e.KeyCode == Keys.Up&&LActs[0].rcDst.X<lelev[0].rcDst.X+360 && LActs[0].rcDst.Y > lelev[0].rcDst.Y - 270&& LActs[0].rcDst.Y < lelev[0].rcDst.Y + 360 && LActs[0].rcDst.Y > lelev[0].rcDst.Y - 270)
            //{


            //        //if (lelev[0].rcDst.X >= 0)
            //        //    lelev[0].rcDst.X -= 20;

            //    lelev[0].rcDst.Y -= 10;
            //    LActs[0].rcDst.Y -= 10;


            //}


            //if (e.KeyCode == Keys.Left && LActs[0].rcDst.X < lelev[0].rcDst.X + 360 && LActs[0].rcDst.Y > lelev[0].rcDst.Y - 270 && LActs[0].rcDst.Y < lelev[0].rcDst.Y + 360 && LActs[0].rcDst.Y > lelev[0].rcDst.Y - 270)
            //{


            //    //if (lelev[0].rcDst.X >= 0)
            //    //    lelev[0].rcDst.X -= 20;

            //    lelev[0].rcDst.X -= 10;
            //    LActs[0].rcDst.X -= 10;


            //}

            //if (e.KeyCode == Keys.Right && LActs[0].rcDst.X < lelev[0].rcDst.X + 360 && LActs[0].rcDst.Y > lelev[0].rcDst.Y - 270 && LActs[0].rcDst.Y < lelev[0].rcDst.Y + 360 && LActs[0].rcDst.Y > lelev[0].rcDst.Y - 270)
            //{


            //    //if (lelev[0].rcDst.X >= 0)
            //    //    lelev[0].rcDst.X -= 20;

            //    lelev[0].rcDst.X += 10;
            //    LActs[0].rcDst.X += 10;


            //}
            //if (e.KeyCode == Keys.Down && LActs[0].rcDst.X < lelev[0].rcDst.X + 360 && LActs[0].rcDst.Y > lelev[0].rcDst.Y - 270 && LActs[0].rcDst.Y < lelev[0].rcDst.Y + 360 && LActs[0].rcDst.Y > lelev[0].rcDst.Y - 270)
            //{


            //    if (lelev[0].rcDst.X >= 0)
            //        lelev[0].rcDst.X -= 20;

            //    lelev[0].rcDst.Y += 10;
            //    LActs[0].rcDst.Y += 10;


            //}



            if (e.KeyCode == Keys.D)
            {

                ff = 0;

                // LActs[i].X += 5;
                if (flagnewmap1 == 0)
                {
                    if (LActs[0].rcDst.X < ldoor[0].rcDst.X + 80 && LActs[0].rcDst.X > ldoor[0].rcDst.X - 80 && LActs[0].rcDst.Y < ldoor[0].rcDst.Y + 80 && LActs[0].rcDst.Y > ldoor[0].rcDst.Y - 80 && flagkey == 0 )

                    {

                    }
                    else if (LActs[0].rcDst.X <= 1800)
                        LActs[0].rcDst.X += 20;
                }
                if(flagnewmap1==1)
                {
                        int fff = 0;
                    for ( i = 0; i < lwall2.Count; i++)
                    {

                        if (LActs[0].rcDst.X < lwall2[i].rcDst.X + 40 && LActs[0].rcDst.X > lwall2[i].rcDst.X - 40 && LActs[0].rcDst.Y < lwall2[i].rcDst.Y + 80 && LActs[0].rcDst.Y > lwall2[i].rcDst.Y - 80)
                        {
                            fff = 1;
                            LActs[0].rcDst.X -= 40;
                            break;
                        }
                       

                    }
                     if(fff==0)
                    {
                        LActs[0].rcDst.X += 20;

                    }
                }


                LActs[0].iCurrFrame++;
                if (LActs[0].iCurrFrame >= 8)
                {
                    LActs[0].iCurrFrame = 0;
                }
                if (flagnewmap1 == 1 && lmap1[0].rcDst.X > -1800)
                {
                    lmap1[0].rcDst.X -= 40;
                    ltank[0].rcDst.X -= 40;
                    for (i = 0; i < lheli.Count; i++)
                    {

                        lheli[i].rcDst.X -= 40;
                    }
                    for ( i = 0; i < lboom.Count; i++)
                    {

                        lboom[i].rcDst.X -= 40;
                    }
                    for (  i = 0;i < lground2.Count;i++ )
                    {
                        lground2[i].rcDst.X -= 40;
                    }
                    for ( i = 0; i < lwall2.Count; i++)
                    {
                    lwall2[i].rcDst.X -= 40;
                    }
                    llader[0].rcDst.X -= 40;
                }
                grav();


            }
            if (e.KeyCode == Keys.Space)
            {
                ff = 0;

                ctofjump = 1;
            }
            if (e.KeyCode == Keys.B)
            {
                ff = 0;

                flipjump = 1;
            }
            if(e.KeyCode == Keys.R&& LActs[0].rcDst.X < ltank[0].rcDst.X + 500 && LActs[0].rcDst.X > ltank[0].rcDst.X - 200 && LActs[0].rcDst.Y > 570)
            {
                tankride = 1;
            }

            if (e.KeyCode == Keys.T)

            {
                tankride = 0;
            }


            if (e.KeyCode == Keys.Right&&tankride==1)

            {
                if (flagnewmap1 == 1 && lmap1[0].rcDst.X < -1800)
                {
                    lmap1[0].rcDst.X -= 40;
                    //ltank[0].rcDst.X -= 40;
                    for (i = 0; i < lboom.Count; i++)
                    {

                        lboom[i].rcDst.X -= 40;
                    }
                    for (i = 0; i < lground2.Count; i++)
                    {
                        lground2[i].rcDst.X -= 40;
                    }
                    for (i = 0; i < lwall2.Count; i++)
                    {
                        lwall2[i].rcDst.X -= 40;
                    }
                    llader[0].rcDst.X -= 40;
                }
                ltank[0].rcDst.X += 20;
                LActs[0].rcDst.X += 20;
                ltank[0].rcDst.Y = 600;
                tankNride = 0;
                if(ltank[0].iCurrFrame==1)
                {
                    ltank[0].rcDst.Y -= 115;

                }

            }

            if (e.KeyCode == Keys.Up && tankride == 1 && flagnewmap1 == 1)

            {
               
                //ltank[0].rcDst.X += 10;
                //LActs[0].rcDst.X += 10;
                ltank[0].iCurrFrame = 1;
                if (tankNride == 0)
                { 
                ltank[0].rcDst.Y -= 115;
                tankNride = 0;
            }
            }
            if (e.KeyCode == Keys.Left && tankride == 1)

            {
                if (flagnewmap1 == 1 && lmap1[0].rcDst.X < 0)
                {
                    lmap1[0].rcDst.X += 40;
                    for (i = 0; i < lboom.Count; i++)
                    {

                        lboom[i].rcDst.X += 40;
                    }
                    for (i = 0; i < lground2.Count; i++)
                    {
                        lground2[i].rcDst.X += 40;
                    }
                    for (i = 0; i < lwall2.Count; i++)
                    {
                        lwall2[i].rcDst.X += 40;
                    }
                    llader[0].rcDst.X += 40;
                }

                    ltank[0].rcDst.X -= 10;
                LActs[0].rcDst.X -= 10;
                //ltank[0].iCurrFrame = 0;
                ltank[0].rcDst.Y = 600;
                tankNride = 0;
                if (ltank[0].iCurrFrame == 1)
                {
                    ltank[0].rcDst.Y -= 115;

                }
                
            }
            if (flagnewmap1 == 1&&e.KeyCode == Keys.Down && tankride == 1)

            {
                //ltank[0].rcDst.X -= 10;
                //LActs[0].rcDst.X -= 10;
                ltank[0].iCurrFrame = 0;
                ltank[0].rcDst.Y = 600;
                tankNride = 0;
            }



            if ( flagnewmap1 == 1&&e.KeyCode == Keys.W&& LActs[0].rcDst.X < llader[0].rcDst.X + 140 && LActs[0].rcDst.X > llader[0].rcDst.X - 8)
            {
                if (LActs[0].rcDst.Y> 460)
                    LActs[0].rcDst.Y -= 20;

            }
            if ( flagnewmap1 == 1&&e.KeyCode == Keys.S && LActs[0].rcDst.X < llader[0].rcDst.X + 140 && LActs[0].rcDst.X > llader[0].rcDst.X - 8)
            {
                if(LActs[0].rcDst.Y<760)
                LActs[0].rcDst.Y += 20;

            }






            if (e.KeyCode == Keys.F)
            {





                ff++;


                if (ff == 1)
                {
                    LActs[0].iCurrFrame = 15;
                    //LActs[0].rcDst.Y -= 20;
                    //LActs[0].rcDst.Y -= 60;
                }
                else
                {

                    LActs[0].iCurrFrame++;

                    if (15 < LActs[0].iCurrFrame)
                    {
                        ff = 0;
                        LActs[0].iCurrFrame = 0;
                        //LActs[0].rcDst.Y += 60;

                        //LActs[0].rcDst.Y += 60;
                    }


                }
                flagct[ww] = 1;
                ww++;

            }
            if (e.KeyCode == Keys.L && lstart == 0)
            {
                lstart = 1;

                //if (Lfireman[0].firediect == 0)
                //{
                //    Lfireman[0].firediect = 1;
                //}


            }

        }
        void Createeliv()
        {
            //Random RR = new Random();

            int X, Y;
            int j = 0;

            elev = new CActor();
            //    pnn.X = RR.Next(100, this.Width);
            elev.rcSrc = new Rectangle(0, 0, 1200/*pnn.imgs.Width*/, 800/*pnn.imgs.Height*/);
            X = 890 + j;
            Y = 350;
            elev.rcDst = new Rectangle(X, Y, 1500, 800);

            // pnn.Y = RR.Next(100, this.Height);

            Bitmap img = new Bitmap(("elev" + ".bmp"));
            Color clr = img.GetPixel(0, 0);
            img.MakeTransparent(clr);
            elev.imgs.Add(img);
            j += 126;
            lelev.Add(elev);
        }


        void ISHIT()
        {

            plaer1health += 10;
            if (plaer1health >= 1050)
            {
                //end = 1;
                //player1lose();
                //player2win();
                //cc = 2;
                //endd();
            }
            else if (plaer1health == 150 || plaer1health == 300 || plaer1health == 450 || plaer1health == 600 || plaer1health == 750 || plaer1health == 900 || plaer1health == 1050)
            {
                p1++;

                lhealth[0].img = new Bitmap("health" + p1 + ".bmp");

            }

            if (plaer1health >= 1050)
            {
                //end = 1;
                //player1lose();
                //player2win();
                //cc = 2;
                //endd();
            }
            //H ++;
            //MessageBox.Show(H+"");





        }

        void createhealthbar()
        {

            off = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
            int X, Y;
            Random RR = new Random();
            int j = 0;
            pnnh = new Cbou();

            pnnh.rcSrc = new Rectangle(0, 0, 1200/*pnn.imgs.Width*/, 1200/*pnn.imgs.Height*/);
            X = 200;
            Y = 100;
            pnnh.rcDst = new Rectangle(X, Y, 1500, 800);


            lhealth.Add(pnnh);
            lhealth[0].img = new Bitmap("health1.bmp");



        }

        //void hit()
        //{
        //    //ctcrouch++;
        //    //enmhit = 0;

        //    enmhit++;
        //    if (enmhit == 1)
        //    {
        //        Lzombies[0].iCurrFrame = 9;
        //    }
        //    else
        //    {


        //        Lzombies[0].iCurrFrame++;

        //        if (10 < Lzombies[0].iCurrFrame)
        //        {
        //            enmhit = 0;
        //            Lzombies[0].iCurrFrame = 0;
        //        }
        //    }
        //    DrawDubb(this.CreateGraphics());

        //    //ISHIT0();
        //}

        void hit()
        {
            //ctcrouch++;
            //enmhit = 0;

            enmhit++;
            if (enmhit == 1)
            {
                Lzombies[0].iCurrFrame = 9;
            }
            else
            {


                Lzombies[0].iCurrFrame++;

                if (10 < Lzombies[0].iCurrFrame)
                {
                    enmhit = 0;
                    Lzombies[0].iCurrFrame = 0;
                }
            }
            //  DrawDubb(this.CreateGraphics());

            //ISHIT0();
        }

        void movezomb()
        {
            for (int i = 0; i < Lzombies.Count; i++)
            {
                if (Lzombies[i].zomdiee == 0)
                {


                    if (Lzombies[i].rcDst.X >= LActs[0].rcDst.X - 100 && Lzombies[i].rcDst.X <= LActs[0].rcDst.X + 100 && Lzombies[i].rcDst.Y > LActs[0].rcDst.Y - 180 && Lzombies[i].rcDst.Y < LActs[0].rcDst.Y + 180)
                    {
                        hit();
                        ISHIT();
                    }


                    else if (Lzombies[i].rcDst.X >= LActs[0].rcDst.X - 400 && Lzombies[i].rcDst.X <= LActs[0].rcDst.X + 400 && Lzombies[i].rcDst.Y > LActs[0].rcDst.Y - 180 && Lzombies[i].rcDst.Y < LActs[0].rcDst.Y + 180)
                    {
                        Lzombies[i].rcDst.X -= 6;
                        Lzombies[i].iCurrFrame++;
                        if (Lzombies[i].iCurrFrame >= 9)
                        {
                            Lzombies[i].iCurrFrame = 0;
                        }

                    }

                    if (Lzombies[i].rcDst.X <= LActs[0].rcDst.X - 40 && Lzombies[i].rcDst.Y > LActs[0].rcDst.Y - 180 && Lzombies[i].rcDst.Y < LActs[0].rcDst.Y + 180)
                        Lzombies[i].rcDst.X += 20;
                }
            }
        }
        void Createbou()
        {
            //Random RR = new Random();

            int X, Y;
            int j = 0;

            pnn69 = new Cbou();
            //    pnn.X = RR.Next(100, this.Width);
            pnn69.rcSrc = new Rectangle(0, 0, 1200/*pnn.imgs.Width*/, 800/*pnn.imgs.Height*/);
            X = 126 + j;
            Y = 170;
            pnn69.rcDst = new Rectangle(X, Y, 1500, 800);

            // pnn.Y = RR.Next(100, this.Height);

            pnn69.img = new Bitmap("b1.bmp");

            j += 126;
            Lbou.Add(pnn69);
        }







        void createfireman()

        {
            off = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);

            Random RR = new Random();

            int X, Y;
            int j = 0;
            for (int i = 0; i < 4; i++)
            {
                CActor pnnf = new CActor();
                //    pnn.X = RR.Next(100, this.Width);
                pnnf.rcSrc = new Rectangle(0, 0, 500/*pnn.imgs.Width*/, 570/*pnn.imgs.Height*/);
                X = lground[10].rcDst.X+j;
                Y = 196;
                pnnf.rcDst = new Rectangle(X, Y, 1000, 1000);

                // pnn.Y = RR.Next(100, this.Height);
                for (int k = 1; k < 2; k++)
                {
                    Bitmap img = new Bitmap(("fireman" + k + ".bmp"));
                    Color clr = img.GetPixel(0, 0);
                    img.MakeTransparent(clr);
                    pnnf.imgs.Add(img);
                }
                for (int k = 2; k < 3; k++)
                {
                    Bitmap img = new Bitmap(("fireman" + k + ".bmp"));
                    Color clr = img.GetPixel(0, 0);
                    img.MakeTransparent(clr);
                    pnnf.imgs.Add(img);
                }
                for (int k = 1; k < 10; k++)
                {
                    Bitmap img = new Bitmap(("firedie" + k + ".bmp"));
                    Color clr = img.GetPixel(0, 0);
                    img.MakeTransparent(clr);
                    pnnf.imgs.Add(img);
                }
                Lfireman.Add(pnnf);
                j += 120;
            }

        }

















        void createzomm()

        {
            off = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);

            Random RR = new Random();

            int X, Y;
            int j = 0;
            for (int i = 0; i < 8; i++)
            {
                CActor zom = new CActor();
                //    pnn.X = RR.Next(100, this.Width);
                zom.rcSrc = new Rectangle(0, 0, 400/*pnn.imgs.Width*/, 400/*pnn.imgs.Height*/);
                X = 500+j;
                Y = 700;
                zom.rcDst = new Rectangle(X, Y, 1000, 1000);

                // pnn.Y = RR.Next(100, this.Height);
                for (int k = 1; k < 9; k++)
                {
                    Bitmap img = new Bitmap(("zomwalk" + k + ".bmp"));
                    Color clr = img.GetPixel(0, 0);
                    img.MakeTransparent(clr);
                    zom.imgs.Add(img);
                }
                for (int k = 1; k < 4; k++)
                {
                    Bitmap img = new Bitmap(("zomfight" + k + ".bmp"));
                    Color clr = img.GetPixel(0, 0);
                    img.MakeTransparent(clr);
                    zom.imgs.Add(img);
                }
                for (int k = 1; k < 9; k++)
                {
                    Bitmap img = new Bitmap(("zomtakeashot" + k + ".bmp"));
                    Color clr = img.GetPixel(0, 0);
                    img.MakeTransparent(clr);
                    zom.imgs.Add(img);
                }
                Lzombies.Add(zom);
                j += 80;
            }
        }
        void map2s()
        {
            newmap1them();
            cBoom();
            cBoomup();
            cBoomright();
            createheli();
            elementformap2();
            createtank();


        }
        void Form1_Load(object sender, EventArgs e)
        {
            //soundPlayer.Play();
            //flagnewmap1 = 1;
            Createeliv();
            Createbou();
            for (int i = 0; i < 100; i++)
            {


                bullets[i] = 1;
                move[i] = 0;
                firemanmovemove[i] = 0;

            }
            off = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);

            Random RR = new Random();

            int X, Y;

            CActor pnn = new CActor();
            //    pnn.X = RR.Next(100, this.Width);
            pnn.rcSrc = new Rectangle(0, 0, 400/*pnn.imgs.Width*/, 400/*pnn.imgs.Height*/);
            X = 160 ;
            Y = 720 ;
            pnn.rcDst = new Rectangle(X, Y, 1000, 1000);

            // pnn.Y = RR.Next(100, this.Height);
            for (int k = 1; k < 9; k++)
            {
                Bitmap img = new Bitmap(("run" + k + ".bmp"));
                Color clr = img.GetPixel(0, 0);
                img.MakeTransparent(clr);
                pnn.imgs.Add(img);
            }
            for (int k = 2; k < 9; k++)
            {
                Bitmap img = new Bitmap(("jump" + k + ".bmp"));
                Color clr = img.GetPixel(0, 0);
                img.MakeTransparent(clr);
                pnn.imgs.Add(img);
            }
            for (int i = 0; i < 1; i++)
            {
                Bitmap img = new Bitmap(("frr" + ".bmp"));
                Color clr = img.GetPixel(0, 0);
                img.MakeTransparent(clr);
                pnn.imgs.Add(img);
            }
            for (int k = 1; k < 9; k++)
            {
                Bitmap img = new Bitmap(("jumm" + k + ".bmp"));
                Color clr = img.GetPixel(0, 0);
                img.MakeTransparent(clr);
                pnn.imgs.Add(img);
            }
            for (int k = 1; k < 7; k++)
            {
                Bitmap img = new Bitmap(("jump1slash" + k + ".bmp"));
                Color clr = img.GetPixel(0, 0);
                img.MakeTransparent(clr);
                pnn.imgs.Add(img);
            }
            for (int k = 1; k < 7; k++)
            {
                Bitmap img = new Bitmap(("fightcom" + k + ".bmp"));
                Color clr = img.GetPixel(0, 0);
                img.MakeTransparent(clr);
                pnn.imgs.Add(img);
            }
                 for (int k = 1; k < 10; k++)
                 {
                Bitmap img = new Bitmap(("jumpslash" + k + ".bmp"));
                Color clr = img.GetPixel(0, 0);
                img.MakeTransparent(clr);
                pnn.imgs.Add(img);
                 }

            


            LActs.Add(pnn);

            createground();
            createwall();
            createdoor();
            towall();
            trap1();
            createkey();

            createzomm();
            createhealthbar();
            createfireman();
        }
        void grav()
        {
            if (flagnewmap1 == 0)
            {
                if (LActs[0].rcDst.X < lelev[0].rcDst.X + 210 && LActs[0].rcDst.X > lelev[0].rcDst.X - 40 && LActs[0].rcDst.Y < lelev[0].rcDst.Y + 30 && LActs[0].rcDst.Y > lelev[0].rcDst.Y - 150)
                {
                    //MessageBox.Show(1 + "");
                }
                else if (LActs[0].rcDst.Y > lground[9].rcDst.Y - 654 && LActs[0].rcDst.Y < lground[9].rcDst.Y + 280 && LActs[0].rcDst.X > lground[9].rcDst.X - 40 && LActs[0].rcDst.X < lground[14].rcDst.X + 60)
                {

                }
                else if (LActs[0].rcDst.Y <= lground[0].rcDst.Y - 140)
                {
                    LActs[0].rcDst.Y += 20;

                }
                // DrawDubb(this.CreateGraphics());
            }

        }
        void gravformap2()
        {
            int flagdown = 0;
            for (int i = 0; i < lground2.Count; i++)
            {
                //if (LActs[0].rcDst.X < lground2[i].rcDst.X + 50 && LActs[0].rcDst.X > lground2[i].rcDst.X - 50 && LActs[0].rcDst.X < lground2[i].rcDst.Y - 50 && LActs[0].rcDst.X > lground2[i].rcDst.Y + 50)
                //{ }
              
               




                if (LActs[0].rcDst.Y > lground2[i].rcDst.Y - 145&& LActs[0].rcDst.X < lground2[i].rcDst.X + 60 && LActs[0].rcDst.X > lground2[i].rcDst.X - 60/* && LActs[0].rcDst.Y < lground2[i].rcDst.Y + 30 && LActs[0].rcDst.Y > lground2[i].rcDst.Y - 150*/)
                {
                    flagdown = 1;

                }
                else if (LActs[0].rcDst.X < llader[0].rcDst.X + 150 && LActs[0].rcDst.X > llader[0].rcDst.X - 8&& LActs[0].rcDst.Y > 440 )
                {
                    flagdown = 1;

                }
                else if  (LActs[0].rcDst.X < ltank[0].rcDst.X + 500 && LActs[0].rcDst.X > ltank[0].rcDst.X - 200 && LActs[0].rcDst.Y > 570)
                    {
                        flagdown = 1;

                    }
                //else
                //{
                //    flagdown = 1;
                //}
            }
            if (flagdown == 1)
            {
              
            }
            else
            {
                LActs[0].rcDst.Y += 20;
            }
        }
        
        
    


        void createkey()
        {
            int X, Y;
            int j = 0;

            pnnd77 = new CActor();

            pnnd77.rcSrc = new Rectangle(0, 0, 400/*pnn.imgs.Width*/, 900/*pnn.imgs.Height*/);
            X = lground[14].rcDst.X;
            Y = lwall[4].rcDst.Y + 30;
            pnnd77.rcDst = new Rectangle(X, Y, 400, 400);


            Bitmap img = new Bitmap(("key" + ".bmp"));
            Color clr = img.GetPixel(0, 0);
            img.MakeTransparent(clr);
            pnnd77.imgs.Add(img);
            j += 180;
            lkey.Add(pnnd77);

        }


        void createdoor()
        {
            int X, Y;
            int j = 0;

            pnnd0 = new CActor();

            pnnd0.rcSrc = new Rectangle(0, 0, 400/*pnn.imgs.Width*/, 900/*pnn.imgs.Height*/);
            X = lground[9].rcDst.X;
            Y = lground[9].rcDst.Y - 140;
            pnnd0.rcDst = new Rectangle(X, Y, 400, 400);


            Bitmap img = new Bitmap(("door" + ".bmp"));
            Color clr = img.GetPixel(0, 0);
            img.MakeTransparent(clr);
            pnnd0.imgs.Add(img);
            j += 180;
            ldoor.Add(pnnd0);

        }
        void towall()
        {


            int X, Y;
            int j = 0;
            for (int i = 0; i < 30; i++)
            {
                pnn50 = new CActor();
                //    pnn.X = RR.Next(100, this.Width);
                pnn50.rcSrc = new Rectangle(0, 0, 400/*pnn.imgs.Width*/, 1200/*pnn.imgs.Height*/);
                X = 130 + j;
                Y = 0;
                pnn50.rcDst = new Rectangle(X, Y, 400, 400);



                Bitmap img = new Bitmap(("wall1" + ".bmp"));
                Color clr = img.GetPixel(0, 0);
                img.MakeTransparent(clr);
                pnn50.imgs.Add(img);
                j += 180;
                ltopwall.Add(pnn50);
            }



        }


        void elementformap2()
        {
            off = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);

            Random RR = new Random();

            int X, Y;
            int j = 0;
            for (int i = 0; i < 8; i++)
            {
                grou2 = new CActor();
                grou2.rcSrc = new Rectangle(0, 0, 126/*pnn.imgs.Width*/, 100/*pnn.imgs.Height*/);
                X = 0 + j;
                Y = 890;
                grou2.rcDst = new Rectangle(X, Y, 400, 400);


                Bitmap img = new Bitmap(("groundd" + ".bmp"));
                //Color clr = img.GetPixel(0, 0);
                //img.MakeTransparent(clr);
                grou2.imgs.Add(img);
                j += 106;
                lground2.Add(grou2);
            }
            j = 0;
            for (int i = 0; i < 8; i++)
            {
                grou2 = new CActor();
                grou2.rcSrc = new Rectangle(0, 0, 126/*pnn.imgs.Width*/, 100/*pnn.imgs.Height*/);
                X = lground2[7].rcDst.X + 40+j;
                Y = 540;
                grou2.rcDst = new Rectangle(X, Y, 400, 400);


                Bitmap img = new Bitmap(("groundd" + ".bmp"));
                //Color clr = img.GetPixel(0, 0);
                //img.MakeTransparent(clr);
                grou2.imgs.Add(img);
                j += 106;
                lground2.Add(grou2);
            }
            j = 0;

            for (int i = 0; i < 1; i++)
            {
                lader = new CActor();
                lader.rcSrc = new Rectangle(0, 0, 400/*pnn.imgs.Width*/, 350/*pnn.imgs.Height*/);
                X = lground2[6].rcDst.X-70;
                Y = 550;
                lader.rcDst = new Rectangle(X, Y, 400, 400);


                Bitmap img = new Bitmap(("ladder" + ".bmp"));
                Color clr = img.GetPixel(0, 0);
                img.MakeTransparent(clr);
                lader.imgs.Add(img);

                llader.Add(lader);
            }
            j = 0;
            for (int i = 0; i < 4; i++)
            {
                wall2 = new CActor();
                wall2.rcSrc = new Rectangle(0, 0, 126/*pnn.imgs.Width*/, 100/*pnn.imgs.Height*/);
                X = lground2[7].rcDst.X+40;
                Y = 860 - j;
                wall2.rcDst = new Rectangle(X, Y, 400, 400);


                Bitmap img = new Bitmap(("groundd" + ".bmp"));
                //Color clr = img.GetPixel(0, 0);
                //img.MakeTransparent(clr);
                wall2.imgs.Add(img);
                j += 106;
                lwall2.Add(wall2);
            }
            j = 0;
            for (int i = 0; i < 4; i++)
            {
                wall2 = new CActor();
                wall2.rcSrc = new Rectangle(0, 0, 126/*pnn.imgs.Width*/, 100/*pnn.imgs.Height*/);
                X = lground2[15].rcDst.X + 40;
                Y = 860 - j;
                wall2.rcDst = new Rectangle(X, Y, 400, 400);


                Bitmap img = new Bitmap(("groundd" + ".bmp"));
                //Color clr = img.GetPixel(0, 0);
                //img.MakeTransparent(clr);
                wall2.imgs.Add(img);
                j += 106;
                lwall2.Add(wall2);
            }
            j = 0;
            for (int i = 0; i < 20; i++)
            {
                grou2 = new CActor();
                grou2.rcSrc = new Rectangle(0, 0, 126/*pnn.imgs.Width*/, 100/*pnn.imgs.Height*/);
                X = lground2[15].rcDst.X + 40 + j;
                Y = 890;
                grou2.rcDst = new Rectangle(X, Y, 400, 400);


                Bitmap img = new Bitmap(("groundd" + ".bmp"));
                //Color clr = img.GetPixel(0, 0);
                //img.MakeTransparent(clr);
                grou2.imgs.Add(img);
                j += 106;
                lground2.Add(grou2);
            }
            j = 0;

        }



        void newmap1them()
        {
            off = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);

            Random RR = new Random();

            int X, Y;
            int j = 0;
            for (int i = 0; i < 2; i++)
            {
                 pnnm1 = new CActor();
                Bitmap img = new Bitmap(("12" + ".gif"));
                pnndm1.rcSrc = new Rectangle(0, 0, img.Width, img.Height);
                X = 0;
                Y = 0;
                pnndm1.rcDst = new Rectangle(0, Y, 4000, this.ClientSize.Height);
                //    pnn.X = RR.Next(100, this.Width);
                pnndm1.imgs.Add(img);
                j += img.Width;
                lmap1.Add(pnndm1);
            }
        }


        void createwall()
        {
            //off = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);

            //Random RR = new Random();

            int X, Y;
            int j = 0;
            for (int i = 0; i < 30; i++)
            {
                pnn100 = new CActor();
                //    pnn.X = RR.Next(100, this.Width);
                pnn100.rcSrc = new Rectangle(0, 0, 800/*pnn.imgs.Width*/, 800/*pnn.imgs.Height*/);
                X = 0;
                Y = 860 - 126 - j;
                pnn100.rcDst = new Rectangle(X, Y, 400, 400);

                // pnn.Y = RR.Next(100, this.Height);

                Bitmap img = new Bitmap(("tileset1" + ".bmp"));
                Color clr = img.GetPixel(0, 0);
                img.MakeTransparent(clr);
                pnn100.imgs.Add(img);
                j += 126;
                lwall.Add(pnn100);
            }
            j = 0;
            for (int i = 0; i < 3; i++)
            {
                pnn100 = new CActor();
                //    pnn.X = RR.Next(100, this.Width);
                pnn100.rcSrc = new Rectangle(0, 0, 800/*pnn.imgs.Width*/, 800/*pnn.imgs.Height*/);
                X = lground[9].rcDst.X;
                Y = lground[9].rcDst.Y - 266 - j;
                pnn100.rcDst = new Rectangle(X, Y, 400, 400);

                // pnn.Y = RR.Next(100, this.Height);

                Bitmap img = new Bitmap(("tileset1" + ".bmp"));
                Color clr = img.GetPixel(0, 0);
                img.MakeTransparent(clr);
                pnn100.imgs.Add(img);
                j += 126;
                lwall.Add(pnn100);
            }
            j = 0;
            for (int i = 0; i < 3; i++)
            {
                pnn100 = new CActor();
                //    pnn.X = RR.Next(100, this.Width);
                pnn100.rcSrc = new Rectangle(0, 0, 800/*pnn.imgs.Width*/, 800/*pnn.imgs.Height*/);
                X = lground[10].rcDst.X;
                Y = lground[9].rcDst.Y - 266 - j;
                pnn100.rcDst = new Rectangle(X, Y, 400, 400);

                // pnn.Y = RR.Next(100, this.Height);

                Bitmap img = new Bitmap(("tileset1" + ".bmp"));
                Color clr = img.GetPixel(0, 0);
                img.MakeTransparent(clr);
                pnn100.imgs.Add(img);
                j += 126;
                lwall.Add(pnn100);
            }
            j = 0;

            for (int i = 0; i < 3; i++)
            {
                pnn100 = new CActor();
                //    pnn.X = RR.Next(100, this.Width);
                pnn100.rcSrc = new Rectangle(0, 0, 800/*pnn.imgs.Width*/, 800/*pnn.imgs.Height*/);
                X = lground[11].rcDst.X;
                Y = lground[9].rcDst.Y - 266 - j;
                pnn100.rcDst = new Rectangle(X, Y, 400, 400);

                // pnn.Y = RR.Next(100, this.Height);

                Bitmap img = new Bitmap(("tileset1" + ".bmp"));
                Color clr = img.GetPixel(0, 0);
                img.MakeTransparent(clr);
                pnn100.imgs.Add(img);
                j += 126;
                lwall.Add(pnn100);
            }
            j = 0;

            for (int i = 0; i < 3; i++)
            {
                pnn100 = new CActor();
                //    pnn.X = RR.Next(100, this.Width);
                pnn100.rcSrc = new Rectangle(0, 0, 800/*pnn.imgs.Width*/, 800/*pnn.imgs.Height*/);
                X = lground[12].rcDst.X;
                Y = lground[9].rcDst.Y - 266 - j;
                pnn100.rcDst = new Rectangle(X, Y, 400, 400);

                // pnn.Y = RR.Next(100, this.Height);

                Bitmap img = new Bitmap(("tileset1" + ".bmp"));
                Color clr = img.GetPixel(0, 0);
                img.MakeTransparent(clr);
                pnn100.imgs.Add(img);
                j += 126;
                lwall.Add(pnn100);
            }
            j = 0;

            for (int i = 0; i < 3; i++)
            {
                pnn100 = new CActor();
                //    pnn.X = RR.Next(100, this.Width);
                pnn100.rcSrc = new Rectangle(0, 0, 800/*pnn.imgs.Width*/, 800/*pnn.imgs.Height*/);
                X = lground[13].rcDst.X;
                Y = lground[9].rcDst.Y - 266 - j;
                pnn100.rcDst = new Rectangle(X, Y, 400, 400);

                // pnn.Y = RR.Next(100, this.Height);

                Bitmap img = new Bitmap(("tileset1" + ".bmp"));
                Color clr = img.GetPixel(0, 0);
                img.MakeTransparent(clr);
                pnn100.imgs.Add(img);
                j += 126;
                lwall.Add(pnn100);
            }
            j = 0;

            for (int i = 0; i < 3; i++)
            {
                pnn100 = new CActor();
                //    pnn.X = RR.Next(100, this.Width);
                pnn100.rcSrc = new Rectangle(0, 0, 800/*pnn.imgs.Width*/, 800/*pnn.imgs.Height*/);
                X = lground[14].rcDst.X;
                Y = lground[9].rcDst.Y - 266 - j;
                pnn100.rcDst = new Rectangle(X, Y, 400, 400);

                // pnn.Y = RR.Next(100, this.Height);

                Bitmap img = new Bitmap(("tileset1" + ".bmp"));
                Color clr = img.GetPixel(0, 0);
                img.MakeTransparent(clr);
                pnn100.imgs.Add(img);
                j += 126;
                lwall.Add(pnn100);
            }
            j = 0;
            for (int i = 0; i < 5; i++)
            {
                pnn100 = new CActor();
                //    pnn.X = RR.Next(100, this.Width);
                pnn100.rcSrc = new Rectangle(0, 0, 800/*pnn.imgs.Width*/, 800/*pnn.imgs.Height*/);
                X = lground[15].rcDst.X;
                Y = lground[9].rcDst.Y - 266 - j;
                pnn100.rcDst = new Rectangle(X, Y, 400, 400);

                // pnn.Y = RR.Next(100, this.Height);

                Bitmap img = new Bitmap(("tileset1" + ".bmp"));
                Color clr = img.GetPixel(0, 0);
                img.MakeTransparent(clr);
                pnn100.imgs.Add(img);
                j += 126;
                lwall.Add(pnn100);
            }

        }
        void createground()
        {
            off = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);

            Random RR = new Random();

            int X, Y;
            int j = 0;
            for (int i = 0; i < 30; i++)
            {
                grou = new CActor();
                grou.rcSrc = new Rectangle(0, 0, 800/*pnn.imgs.Width*/, 800/*pnn.imgs.Height*/);
                X = 0 + j;
                Y = 860;
                grou.rcDst = new Rectangle(X, Y, 400, 400);


                Bitmap img = new Bitmap(("tileset1" + ".bmp"));
                Color clr = img.GetPixel(0, 0);
                img.MakeTransparent(clr);
                grou.imgs.Add(img);
                j += 126;
                lground.Add(grou);
            }



        }
        void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawDubb(e.Graphics);
        }
        void DrawDubb(Graphics g)
        {
            Graphics g2 = Graphics.FromImage(off);
            DrawScene(g2);
            g.DrawImage(off, 0, 0);
        }
        void DrawScene(Graphics g)
        {

            //g.Clear(Color.Gray);
            g.DrawImage(BK, 0, 0, this.Width, this.Height);
            Color clr;

            //for (int i = 0; i < LActs.Count; i++)
            //{


            if (flagnewmap1 == 0)
            {
                for (int i = 0; i < lground.Count; i++)
                {
                    int q = lground[i].iCurrFrame;

                    g.DrawImage(lground[i].imgs[q], lground[i].rcDst, lground[i].rcSrc, GraphicsUnit.Pixel);

                }
                for (int i = 0; i < lwall.Count; i++)
                {
                    int q = lwall[i].iCurrFrame;

                    g.DrawImage(lwall[i].imgs[q], lwall[i].rcDst, lwall[i].rcSrc, GraphicsUnit.Pixel);

                }

                for (int i = 0; i < ltopwall.Count; i++)
                {
                    int q = ltopwall[i].iCurrFrame;

                    g.DrawImage(ltopwall[i].imgs[q], ltopwall[i].rcDst, ltopwall[i].rcSrc, GraphicsUnit.Pixel);

                }

                //int q = ldoor[0].iCurrFrame;

                g.DrawImage(ldoor[0].imgs[0], ldoor[0].rcDst, ldoor[0].rcSrc, GraphicsUnit.Pixel);


                int k = LActs[0].iCurrFrame;

                g.DrawImage(LActs[0].imgs[k], LActs[0].rcDst, LActs[0].rcSrc, GraphicsUnit.Pixel);



                for (int i = 0; i < Lzombies.Count; i++)
                {


                    int rr = Lzombies[i].iCurrFrame;

                    g.DrawImage(Lzombies[i].imgs[rr], Lzombies[i].rcDst, Lzombies[i].rcSrc, GraphicsUnit.Pixel);

                }
                for (int i = 0; i < lfire.Count; i++)
                {
                    int q = lfire[i].iCurrFrame;

                    g.DrawImage(lfire[i].imgs[0], lfire[i].rcDst, lfire[i].rcSrc, GraphicsUnit.Pixel);

                }
                for (int i = 0; i < llazer.Count; i++)
                {
                    int q = llazer[i].iCurrFrame;

                    g.DrawImage(llazer[i].imgs[q], llazer[i].rcDst, llazer[i].rcSrc, GraphicsUnit.Pixel);

                }



                int ss = lelev[0].iCurrFrame;

                g.DrawImage(lelev[0].imgs[0], lelev[0].rcDst, lelev[0].rcSrc, GraphicsUnit.Pixel);

                for (int i = 0; i < lfireon.Count; i++)
                {
                    int q = lfireon[i].iCurrFrame;

                    g.DrawImage(lfireon[i].imgs[0], lfireon[i].rcDst, lfireon[i].rcSrc, GraphicsUnit.Pixel);

                }


                for (int i = 0; i < Lfireman.Count; i++)
                {
                    int q = Lfireman[i].iCurrFrame;

                    g.DrawImage(Lfireman[i].imgs[q], Lfireman[i].rcDst, Lfireman[i].rcSrc, GraphicsUnit.Pixel);

                }

                for (int i = 0; i < lbull.Count; i++)
                {
                    int q = lbull[i].iCurrFrame;

                    g.DrawImage(lbull[i].imgs[q], lbull[i].rcDst, lbull[i].rcSrc, GraphicsUnit.Pixel);

                }



                if (flagkey == 0)
                {
                    g.DrawImage(lkey[0].imgs[0], lkey[0].rcDst, lkey[0].rcSrc, GraphicsUnit.Pixel);
                }

                clr = Lbou[0].img.GetPixel(0, 0);
                Lbou[0].img.MakeTransparent(clr);
                g.DrawImage(Lbou[0].img, Lbou[0].rcDst, Lbou[0].rcSrc, GraphicsUnit.Pixel);

                clr = Ltrap[0].img.GetPixel(0, 0);
                Ltrap[0].img.MakeTransparent(clr);
                g.DrawImage(Ltrap[0].img, Ltrap[0].rcDst, Ltrap[0].rcSrc, GraphicsUnit.Pixel);



                clr = lhealth[0].img.GetPixel(0, 0);
                lhealth[0].img.MakeTransparent(clr);
                g.DrawImage(lhealth[0].img, lhealth[0].rcDst, lhealth[0].rcSrc, GraphicsUnit.Pixel);
            }
            else if (flagnewmap1 == 1)
            {
                if(map2start==0)
                {
                    map2s();
                    map2start = 1;
                    LActs[0].rcDst.X = 0;
                }
                for (int i = 0; i < lmap1.Count; i++)
                {
                    int q = lmap1[i].iCurrFrame;

                    g.DrawImage(lmap1[i].imgs[q], lmap1[i].rcDst, lmap1[i].rcSrc, GraphicsUnit.Pixel);

                }


                for (int i = 0; i < lground2.Count; i++)
                {
                    int q = lground2[i].iCurrFrame;

                    g.DrawImage(lground2[i].imgs[q], lground2[i].rcDst, lground2[i].rcSrc, GraphicsUnit.Pixel);

                }

                for (int i = 0; i < llader.Count; i++)
                {
                    int q = llader[i].iCurrFrame;

                    g.DrawImage(llader[i].imgs[q], llader[i].rcDst, llader[i].rcSrc, GraphicsUnit.Pixel);

                }
                for (int i = 0; i < lwall2.Count; i++)
                {
                    int q = lwall2[i].iCurrFrame;

                    g.DrawImage(lwall2[i].imgs[q], lwall2[i].rcDst, lwall2[i].rcSrc, GraphicsUnit.Pixel);

                }
                for (int i = 0; i < lheli.Count; i++)
                {
                    int q = lheli[i].iCurrFrame;

                    g.DrawImage(lheli[i].imgs[q], lheli[i].rcDst, lheli[i].rcSrc, GraphicsUnit.Pixel);

                }
                for (int i = 0; i < lhelifire.Count; i++)
                {
                    int q = lhelifire[i].iCurrFrame;

                    g.DrawImage(lhelifire[i].imgs[q], lhelifire[i].rcDst, lhelifire[i].rcSrc, GraphicsUnit.Pixel);

                }
                for (int i = 0; i < lbull.Count; i++)
                {
                    int q = lbull[i].iCurrFrame;

                    g.DrawImage(lbull[i].imgs[q], lbull[i].rcDst, lbull[i].rcSrc, GraphicsUnit.Pixel);

                }
                for (int i = 0; i < llazer.Count; i++)
                {
                    int q = llazer[i].iCurrFrame;

                    g.DrawImage(llazer[i].imgs[q], llazer[i].rcDst, llazer[i].rcSrc, GraphicsUnit.Pixel);

                }
              
                clr = lhealth[0].img.GetPixel(0, 0);
                lhealth[0].img.MakeTransparent(clr);
                g.DrawImage(lhealth[0].img, lhealth[0].rcDst, lhealth[0].rcSrc, GraphicsUnit.Pixel);

                if (tankride==0)
                { 
                int k = LActs[0].iCurrFrame;

                g.DrawImage(LActs[0].imgs[k], LActs[0].rcDst, LActs[0].rcSrc, GraphicsUnit.Pixel);
                 }
                for (int i = 0; i < ltank.Count; i++)
                {
                    int q = ltank[i].iCurrFrame;

                    g.DrawImage(ltank[i].imgs[q], ltank[i].rcDst, ltank[i].rcSrc, GraphicsUnit.Pixel);

                }
                for (int i = 0; i < ltankbull.Count; i++)
                {
                    int q = ltankbull[i].iCurrFrame;

                    g.DrawImage(ltankbull[i].imgs[q], ltankbull[i].rcDst, ltankbull[i].rcSrc, GraphicsUnit.Pixel);

                }
                for (int i = 0; i < lboom.Count; i++)
                {
                    int q = lboom[i].iCurrFrame;

                    g.DrawImage(lboom[i].imgs[q], lboom[i].rcDst, lboom[i].rcSrc, GraphicsUnit.Pixel);

                }
            }

        }
    }
    }


