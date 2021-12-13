using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

// The title of your mod, as displayed in menus
[assembly: AssemblyTitle("Placeholder")]

// The author of the mod
[assembly: AssemblyCompany("Josh and Lucas")]

// The description of the mod
[assembly: AssemblyDescription("Test mod")]

// The mod's version
[assembly: AssemblyVersion("0.1")]

namespace DuckGame.MyMod
{
    public class name_placeholder : Mod
    {
        // The mod's priority; this property controls the load order of the mod.
        public override Priority priority
        {
            get { return base.priority; }
        }

        // This function is run before all mods are finished loading.
        protected override void OnPreInitialize()
        {
            base.OnPreInitialize();
        }

        // This function is run after all mods are loaded.
        protected override void OnPostInitialize()
        {
            Teams.core.teams.Add(new Team("lukie", Mod.GetPath<name_placeholder>("hat"), false, false, new Vec2()));
            Teams.core.teams.Add(new Team("barr", Mod.GetPath<name_placeholder>("barr"), false, false, new Vec2()));

            base.OnPostInitialize();
        }
    }
}
