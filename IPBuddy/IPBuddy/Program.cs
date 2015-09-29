using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EloBuddy;
using EloBuddy.SDK;
using EloBuddy.SDK.Enumerations;
using EloBuddy.SDK.Events;
using EloBuddy.SDK.Menu;
using EloBuddy.SDK.Menu.Values;
using EloBuddy.SDK.Rendering;
using SharpDX;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Threading;
using System.Net;

namespace IPBuddy
{
    class Program
    {
        public static Menu IPBuddyMenu;

        private static void Main(string[] args)
        {
            Loading.OnLoadingComplete += Game_OnStart;
        }

        private static void Game_OnStart(EventArgs args)
        {
                ///IPBuddyMenu.Add(new MenuItem("IPwinn", "At Win: "));
               /// IPBuddyMenu.Add(new MenuItem("IPlosee", "At Lose: "));
                ///IPBuddyMenu.Add(new MenuItem("ipminute", ""));
               /// var press1 = IPBuddyMenu.Add(new MenuItem("tiklagelsin", "Write Key").SetValue(new KeyBind(85, KeyBindType.Press)));
               /// IPBuddyMenu.Add(new MenuItem("warnmessge", "Only you can see chat texts."));

            Chat.Print("<font color = \"#0099FF\">IPBuddy<font color = \"#FFFFCC\"> is loaded. ^.^</font>");
            IPBuddyMenu = MainMenu.AddMenu("IPBuddy", "IPBuddy");
            IPBuddyMenu.AddGroupLabel("IPBuddyMenu");
            IPBuddyMenu.AddLabel("Credits to Kindred.");
            IPBuddyMenu.Add("enabled", new CheckBox("See IP buddy", false));

            Game.OnUpdate += OnUpdate;
        }

        public static void OnUpdate(EventArgs args)
        {

            double ipminute = Game.Time / 60 - 1;
            float gametimer = Game.Time / 60 - 1;
            double winnip = 18 + 2.312 * ipminute;
            double loseeip = 16 + 1.405 * ipminute;
            ///IPBuddyMenu.AddLabel("At win you will get " + winnip + " IP!");
            ///IPBuddyMenu.AddLabel("At lose you will get " + loseeip + " IP!");
            ///IPBuddyMenu.AddLabel("Minute is " + gametimer);

            double tick = 0;
            tick = TimeSpan.FromSeconds(Environment.TickCount).Minutes;
            if (IPBuddyMenu["enabled"].Cast<CheckBox>().CurrentValue && tick == 30)
            {
                WriteIPBuddy();
            }
        }
        public static void WriteIPBuddy()
        {
            double ipminute = Game.Time / 60 - 1;
            double winnip = 18 + 2.312 * ipminute;
            double loseeip = 16 + 1.405 * ipminute;
            Chat.Print("<font color = \"#39f613\">At win you will get </font>" + winnip + " IP!");
            Chat.Print("<font color = \"#FF0000\">At lose you will get </font>" + loseeip + " IP!");
        }
    }
}
