﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeagueSharp;
using LeagueSharp.Common;
using SharpDX;
using Color = System.Drawing.Color;

namespace xWard
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomEvents.Game.OnGameLoad += Game_OnGameLoad;
        }
    
        public static Items.Item WardS, WardN, TrinketN, SightStone;
        public static Menu Menu;
        private static readonly Obj_AI_Hero player = ObjectManager.Player;

        private static void Game_OnGameLoad(EventArgs args)
        {
            WardS = new Items.Item(2043, 600f);
            WardN = new Items.Item(2044, 600f);
            TrinketN = new Items.Item(3340, 600f);
            SightStone = new Items.Item(2049, 600f);

            Menu = new Menu("DropHackPotente", "DropHack Potente", true);
            {
                var LadoRojo = new Menu("Lado Rojo", "Lado Rojo");
                {
                    LadoRojo.AddItem(new MenuItem("DibujarRojo", "Dibujar Circulos Wards Rojo :P").SetValue(false));
                    LadoRojo.AddItem(new MenuItem("WardsRojo", "Hacer la Magia").SetValue(new KeyBind('R', KeyBindType.Press)));
                    Menu.AddSubMenu(LadoRojo);
                }

                var LadoAzul = new Menu("Lado Azul", "Lado Azul");
                {
                    LadoAzul.AddItem(new MenuItem("DibujarAzul", "Dibujar Circulos Wards Azul :P").SetValue(false));
                    LadoAzul.AddItem(new MenuItem("WardsAzul", "Hacer la Magia").SetValue(new KeyBind('A', KeyBindType.Press)));
                    Menu.AddSubMenu(LadoAzul);
                }
                var Generales = new Menu("Activar Generales", "(rivera, baron, dragon etc..)");
                {
                    Generales.AddItem(new MenuItem("DibujarGenerales", "Circulos Wards Generales :P").SetValue(false));
                    Generales.AddItem(new MenuItem("WardsGeneral", "Hacer la Magia").SetValue(new KeyBind('G', KeyBindType.Press)));
                    Menu.AddSubMenu(Generales);
                }
                Menu.AddToMainMenu();
            }
            Drawing.OnDraw += Dibujar_Wards;
            Game.OnGameUpdate += Game_OnGameUpdate;
            Game.PrintChat("xWard Modificado, Todos los créditos para xXero esto es solo una simple modificacion.");
        }

        static void Game_OnGameUpdate(EventArgs args)
        {
            if (Menu.Item("WardsRojo").GetValue<KeyBind>().Active)
            {
                PonerRojos();
            }
            if (Menu.Item("WardsAzul").GetValue<KeyBind>().Active)
            {
                PonerAzules();
            }
            if (Menu.Item("WardsAzul").GetValue<KeyBind>().Active)
            {
                PonerGenerales();
            }
        }

        static void Dibujar_Wards(EventArgs args)
        {
            if (Menu.Item("DibujarAzul").GetValue<bool>())
            {
                Render.Circle.DrawCircle(new Vector3(3261.93f, 7773.65f, 60.0f), 125f, Color.Blue);// Blue Golem
                Render.Circle.DrawCircle(new Vector3(7831.46f, 3501.13f, 60.0f), 125f, Color.Blue);// Blue Lizard
                Render.Circle.DrawCircle(new Vector3(10586.62f, 3067.93f, 60.0f), 125f, Color.Blue);// Blue Tri Bush
                Render.Circle.DrawCircle(new Vector3(6483.73f, 4606.57f, 60.0f), 125f, Color.Blue);// Blue Pass Bush
                Render.Circle.DrawCircle(new Vector3(7610.46f, 5000.0f, 60.0f), 125f, Color.Blue);// Blue River Entrance
                Render.Circle.DrawCircle(new Vector3(4717.09f, 7142.35f, 50.83f), 125f, Color.Blue);// Blue Round Bush
                Render.Circle.DrawCircle(new Vector3(4882.86f, 8393.77f, 27.83f), 125f, Color.Blue);// Blue River Round Bush
                Render.Circle.DrawCircle(new Vector3(6951.01f, 3040.55f, 52.26f), 125f, Color.Blue);// Blue Split Push Bush
                Render.Circle.DrawCircle(new Vector3(5583.74f, 3573.83f, 51.43f), 125f, Color.Blue);// Blue Riveer Center Close

                Render.Circle.DrawCircle(new Vector3(4749.79f, 5890.76f, 53.59f), 125f, Color.Blue);// Blue Mid T1
                Render.Circle.DrawCircle(new Vector3(5983.58f, 1547.98f, 52.99f), 125f, Color.Blue);// Blue Bot T2
                Render.Circle.DrawCircle(new Vector3(1213.70f, 5324.73f, 58.77f), 125f, Color.Blue);// Blue Top T2
            }
            if (Menu.Item("DibujarRojo").GetValue<bool>())
            {
                Render.Circle.DrawCircle(new Vector3(11600.35f, 7090.37f, 51.73f), 125f, Color.Red);// Red Golem
                Render.Circle.DrawCircle(new Vector3(11573.9f, 6457.76f, 51.71f), 125f, Color.Red);// Red Golem2
                Render.Circle.DrawCircle(new Vector3(12629.72f, 4908.16f, 48.62f), 125f, Color.Red);// Red Tri Bush2
                Render.Circle.DrawCircle(new Vector3(7018.75f, 11362.12f, 54.76f), 125f, Color.Red);// Red Lizard
                Render.Circle.DrawCircle(new Vector3(4232.69f, 11869.25f, 47.56f), 125f, Color.Red);// Red Tri Bush
                Render.Circle.DrawCircle(new Vector3(8198.22f, 10267.89f, 49.38f), 125f, Color.Red);// Red Pass Bush
                Render.Circle.DrawCircle(new Vector3(7202.43f, 9881.83f, 53.18f), 125f, Color.Red);// Red River Entrance
                Render.Circle.DrawCircle(new Vector3(10074.63f, 7761.62f, 51.74f), 125f, Color.Red);// Red Round Bush
                Render.Circle.DrawCircle(new Vector3(9795.85f, 6355.15f, -12.21f), 125f, Color.Red);// Red River Round Bush
                Render.Circle.DrawCircle(new Vector3(7836.85f, 11906.34f, 56.48f), 125f, Color.Red);// Red Split Push Bush

                Render.Circle.DrawCircle(new Vector3(12731.25f, 9132.66f, 50.32f), 125f, Color.Red);// Red Bot T2
                Render.Circle.DrawCircle(new Vector3(8036.52f, 12882.94f, 45.19f), 125f, Color.Red);// Red Bot T2
                Render.Circle.DrawCircle(new Vector3(9757.9f, 8768.25f, 50.73f), 125f, Color.Red);// Red Mid T1

                Render.Circle.DrawCircle(new Vector3(8223.67f, 8110.15f, 60.0f), 125f, Color.Red);   // Purple Nidlane
                Render.Circle.DrawCircle(new Vector3(9736.8f, 6916.26f, 51.98f), 125f, Color.Red);   // Purple Mid Path
            }
            if (Menu.Item("DibujarGenerales").GetValue<bool>())
            {
                Render.Circle.DrawCircle(new Vector3(10546.35f, 5019.06f, -60.0f), 125f, Color.White);// Dragon
                Render.Circle.DrawCircle(new Vector3(9344.95f, 5703.43f, -64.07f), 125f, Color.White);// Dragon Bush
                Render.Circle.DrawCircle(new Vector3(4334.98f, 9714.54f, -60.42f), 125f, Color.White);// Baron
                Render.Circle.DrawCircle(new Vector3(5363.31f, 9157.05f, -62.70f), 125f, Color.White);// Baron Bush
            }
        }

        private static void PonerRojos()
        {
            if (TrinketN.IsReady())
            {
                TrinketN.Cast(new Vector3(11600.35f, 7090.37f, 51.73f));// Red Golem
                TrinketN.Cast(new Vector3(11573.9f, 6457.76f, 51.71f));// Red Golem2
                TrinketN.Cast(new Vector3(12629.72f, 4908.16f, 48.62f));// Red Tri Bush2
                TrinketN.Cast(new Vector3(7018.75f, 11362.12f, 54.76f));// Red Lizard
                TrinketN.Cast(new Vector3(4232.69f, 11869.25f, 47.56f));// Red Tri Bush
                TrinketN.Cast(new Vector3(8198.22f, 10267.89f, 49.38f));// Red Pass Bush
                TrinketN.Cast(new Vector3(7202.43f, 9881.83f, 53.18f));// Red River Entrance
                TrinketN.Cast(new Vector3(10074.63f, 7761.62f, 51.74f));// Red Round Bush
                TrinketN.Cast(new Vector3(9795.85f, 6355.15f, -12.21f));// Red River Round Bush
                TrinketN.Cast(new Vector3(7836.85f, 11906.34f, 56.48f));// Red Split Push Bush

                TrinketN.Cast(new Vector3(12731.25f, 9132.66f, 50.32f));// Red Bot T2
                TrinketN.Cast(new Vector3(8036.52f, 12882.94f, 45.19f));// Red Bot T2
                TrinketN.Cast(new Vector3(9757.9f, 8768.25f, 50.73f));// Red Mid T1

                TrinketN.Cast(new Vector3(8223.67f, 8110.15f, 60.0f));   // Purple Nidlane
                TrinketN.Cast(new Vector3(9736.8f, 6916.26f, 51.98f));   // Purple Mid Path
            }

            if (SightStone.IsReady())
            {
                SightStone.Cast(new Vector3(11600.35f, 7090.37f, 51.73f));// Red Golem
                SightStone.Cast(new Vector3(11573.9f, 6457.76f, 51.71f));// Red Golem2
                SightStone.Cast(new Vector3(12629.72f, 4908.16f, 48.62f));// Red Tri Bush2
                SightStone.Cast(new Vector3(7018.75f, 11362.12f, 54.76f));// Red Lizard
                SightStone.Cast(new Vector3(4232.69f, 11869.25f, 47.56f));// Red Tri Bush
                SightStone.Cast(new Vector3(8198.22f, 10267.89f, 49.38f));// Red Pass Bush
                SightStone.Cast(new Vector3(7202.43f, 9881.83f, 53.18f));// Red River Entrance
                SightStone.Cast(new Vector3(10074.63f, 7761.62f, 51.74f));// Red Round Bush
                SightStone.Cast(new Vector3(9795.85f, 6355.15f, -12.21f));// Red River Round Bush
                SightStone.Cast(new Vector3(7836.85f, 11906.34f, 56.48f));// Red Split Push Bush

                SightStone.Cast(new Vector3(12731.25f, 9132.66f, 50.32f));// Red Bot T2
                SightStone.Cast(new Vector3(8036.52f, 12882.94f, 45.19f));// Red Bot T2
                SightStone.Cast(new Vector3(9757.9f, 8768.25f, 50.73f));// Red Mid T1

                SightStone.Cast(new Vector3(8223.67f, 8110.15f, 60.0f));   // Purple Nidlane
                SightStone.Cast(new Vector3(9736.8f, 6916.26f, 51.98f));   // Purple Mid Path
            }

            if (WardS.IsReady())
            {
                WardS.Cast(new Vector3(11600.35f, 7090.37f, 51.73f));// Red Golem
                WardS.Cast(new Vector3(11573.9f, 6457.76f, 51.71f));// Red Golem2
                WardS.Cast(new Vector3(12629.72f, 4908.16f, 48.62f));// Red Tri Bush2
                WardS.Cast(new Vector3(7018.75f, 11362.12f, 54.76f));// Red Lizard
                WardS.Cast(new Vector3(4232.69f, 11869.25f, 47.56f));// Red Tri Bush
                WardS.Cast(new Vector3(8198.22f, 10267.89f, 49.38f));// Red Pass Bush
                WardS.Cast(new Vector3(7202.43f, 9881.83f, 53.18f));// Red River Entrance
                WardS.Cast(new Vector3(10074.63f, 7761.62f, 51.74f));// Red Round Bush
                WardS.Cast(new Vector3(9795.85f, 6355.15f, -12.21f));// Red River Round Bush
                WardS.Cast(new Vector3(7836.85f, 11906.34f, 56.48f));// Red Split Push Bush

                WardS.Cast(new Vector3(12731.25f, 9132.66f, 50.32f));// Red Bot T2
                WardS.Cast(new Vector3(8036.52f, 12882.94f, 45.19f));// Red Bot T2
                WardS.Cast(new Vector3(9757.9f, 8768.25f, 50.73f));// Red Mid T1

                WardS.Cast(new Vector3(8223.67f, 8110.15f, 60.0f));   // Purple Nidlane
                WardS.Cast(new Vector3(9736.8f, 6916.26f, 51.98f));   // Purple Mid Path
            }


            if (WardN.IsReady())
            {
                WardN.Cast(new Vector3(11600.35f, 7090.37f, 51.73f));// Red Golem
                WardN.Cast(new Vector3(11573.9f, 6457.76f, 51.71f));// Red Golem2
                WardN.Cast(new Vector3(12629.72f, 4908.16f, 48.62f));// Red Tri Bush2
                WardN.Cast(new Vector3(7018.75f, 11362.12f, 54.76f));// Red Lizard
                WardN.Cast(new Vector3(4232.69f, 11869.25f, 47.56f));// Red Tri Bush
                WardN.Cast(new Vector3(8198.22f, 10267.89f, 49.38f));// Red Pass Bush
                WardN.Cast(new Vector3(7202.43f, 9881.83f, 53.18f));// Red River Entrance
                WardN.Cast(new Vector3(10074.63f, 7761.62f, 51.74f));// Red Round Bush
                WardN.Cast(new Vector3(9795.85f, 6355.15f, -12.21f));// Red River Round Bush
                WardN.Cast(new Vector3(7836.85f, 11906.34f, 56.48f));// Red Split Push Bush

                WardN.Cast(new Vector3(12731.25f, 9132.66f, 50.32f));// Red Bot T2
                WardN.Cast(new Vector3(8036.52f, 12882.94f, 45.19f));// Red Bot T2
                WardN.Cast(new Vector3(9757.9f, 8768.25f, 50.73f));// Red Mid T1

                WardN.Cast(new Vector3(8223.67f, 8110.15f, 60.0f));   // Purple Nidlane
                WardN.Cast(new Vector3(9736.8f, 6916.26f, 51.98f));   // Purple Mid Path
            }
        }

        private static void PonerAzules()
        {
            if (TrinketN.IsReady())
            {
            }

            if (SightStone.IsReady())
            {
            }

            if (WardS.IsReady())
            {
            }


            if (WardN.IsReady())
            {
            }

        }

        private static void PonerGenerales()
        {
            if (TrinketN.IsReady())
            {
            }

            if (SightStone.IsReady())
            {
            }

            if (WardS.IsReady())
            {
            }


            if (WardN.IsReady())
            {
            }
        }
    }
}

   
