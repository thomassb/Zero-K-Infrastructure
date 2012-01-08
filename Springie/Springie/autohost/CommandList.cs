﻿using System.Collections.Generic;
using System.Linq;
using LobbyClient;
using PlasmaShared.SpringieInterfaceReference;

namespace Springie.autohost
{
    class CommandList
    {
        public List<CommandConfig> Commands = new List<CommandConfig>();

        public CommandList(AhConfig config)
        {
            AddMissing(new CommandConfig("help", 0, " - lists all commands available specifically to you", 5));

            AddMissing(new CommandConfig("random",
                                         1,
                                         "<allycount> - assigns people to <allycount> random alliances, e.g. !random - makes 2 random alliances",
                                         10));

            AddMissing(new CommandConfig("balance",
                                         1,
                                         "<allycount> - assigns people to <allycount> rank balanced alliances, e.g. !balance - makes 2 random but balanced alliances",
                                         10));

            AddMissing(new CommandConfig("start", 1, " - starts game", 5));

            AddMissing(new CommandConfig("ring",
                                         0,
                                         "[<filters>..] - rings all unready or specific player(s), e.g. !ring - rings unready, !ring icho - rings Licho",
                                         5,
                                         new[] { TasSayEventArgs.Places.Normal, TasSayEventArgs.Places.Battle, TasSayEventArgs.Places.Game }));

            AddMissing(new CommandConfig("listmaps", 0, "[<filters>..] - lists maps on server, e.g. !listmaps altor div", 10));

            AddMissing(new CommandConfig("listmods", 0, "[<filters>..] - lists mods on server, e.g. !listmods absolute 2.23", 5));
            AddMissing(new CommandConfig("map", 2, "[<filters>..] - changes server map, eg. !map altor div"));

            AddMissing(new CommandConfig("manage", 1, "<minaplayer> [<maxplayers>] [<team count>] - auto manage server for min to max players"));
            AddMissing(new CommandConfig("cmanage",
                                         1,
                                         "<minaplayer> [<maxplayers>] [<team count>] - auto manage server for min to max players - respects clans"));

            AddMissing(new CommandConfig("forcestart", 2, " - starts game forcibly (ignoring warnings)", 5));

            AddMissing(new CommandConfig("say",
                                         0,
                                         "<text> - says something in game",
                                         0,
                                         new[] { TasSayEventArgs.Places.Normal, TasSayEventArgs.Places.Battle, TasSayEventArgs.Places.Game }));

            AddMissing(new CommandConfig("force",
                                         2,
                                         " - forces game start inside game",
                                         8,
                                         new[] { TasSayEventArgs.Places.Normal, TasSayEventArgs.Places.Battle, TasSayEventArgs.Places.Game }));
            AddMissing(new CommandConfig("kick",
                                         3,
                                         "[<filters>..] - kicks a player",
                                         0,
                                         new[] { TasSayEventArgs.Places.Normal, TasSayEventArgs.Places.Battle, TasSayEventArgs.Places.Game }));

            AddMissing(new CommandConfig("split", 1, "<\"h\"/\"v\"> <percent> - draws with given direction and percentual size, e.g. !split h 15"));

            AddMissing(new CommandConfig("transmit", 0, "Internal command transfer to ingame"));

            AddMissing(new CommandConfig("corners", 1, "<\"a\"/\"b\"> <percent> - draws corners (a or b mode differ in ordering), e.g. !corners a 15"));

            AddMissing(new CommandConfig("exit",
                                         3,
                                         " - exits the game",
                                         0,
                                         new[] { TasSayEventArgs.Places.Normal, TasSayEventArgs.Places.Battle, TasSayEventArgs.Places.Game }));

            AddMissing(new CommandConfig("lock", 1, " - locks the game"));

            AddMissing(new CommandConfig("unlock", 1, " - unlocks the game"));

            AddMissing(new CommandConfig("fix", 1, " - fixes teamnumbers", 5));

            AddMissing(new CommandConfig("votemap", 0, "[<mapname>..] - starts vote for new map, e.g. !votemap altored div"));

            AddMissing(new CommandConfig("votekick",
                                         0,
                                         "[<playerame>..] - starts vote to kick a player, e.g. !votekick Licho",
                                         0,
                                         new[] { TasSayEventArgs.Places.Normal, TasSayEventArgs.Places.Battle, TasSayEventArgs.Places.Game }));

            AddMissing(new CommandConfig("votespec",
                                         0,
                                         "[<playername>..] - starts vote to spectate player, e.g. !votespec Licho",
                                         0,
                                         new[] { TasSayEventArgs.Places.Normal, TasSayEventArgs.Places.Battle, TasSayEventArgs.Places.Game }));

            AddMissing(new CommandConfig("votesplitplayers",
                                         0,
                                         "- starts vote to split the game into 2",
                                         0,
                                         new[] { TasSayEventArgs.Places.Normal, TasSayEventArgs.Places.Battle, TasSayEventArgs.Places.Game }));

            AddMissing(new CommandConfig("splitplayers",
                                         2,
                                         " - splots players to 2 hosts based on their elo",
                                         2,
                                         new[] { TasSayEventArgs.Places.Normal, TasSayEventArgs.Places.Battle, TasSayEventArgs.Places.Game }));

            AddMissing(new CommandConfig("voteforcestart", 0, " - starts vote to force game to start in lobby"));

            AddMissing(new CommandConfig("voteforce",
                                         0,
                                         " - starts vote to force game to start from game",
                                         0,
                                         new[] { TasSayEventArgs.Places.Normal, TasSayEventArgs.Places.Battle, TasSayEventArgs.Places.Game }));

            AddMissing(new CommandConfig("voteexit",
                                         0,
                                         " - starts vote to exit game",
                                         0,
                                         new[] { TasSayEventArgs.Places.Normal, TasSayEventArgs.Places.Battle, TasSayEventArgs.Places.Game }));

            AddMissing(new CommandConfig("vote",
                                         0,
                                         "<number> - votes for given option (works from battle only), e.g. !vote 1",
                                         0,
                                         new[] { TasSayEventArgs.Places.Battle, TasSayEventArgs.Places.Game }));

            AddMissing(new CommandConfig("rehost", 3, "[<modname>..] - rehosts game, e.g. !rehost abosol 2.23 - rehosts AA2.23"));
            AddMissing(new CommandConfig("voterehost",
                                         0,
                                         "[<modname>..] - votes to rehost game, e.g. !rehost abosol 2.23 - rehosts AA2.23",
                                         0,
                                         new[] { TasSayEventArgs.Places.Normal, TasSayEventArgs.Places.Battle, TasSayEventArgs.Places.Game }));

            AddMissing(new CommandConfig("admins", 0, " - lists admins", 5));

            AddMissing(new CommandConfig("maplink",
                                         0,
                                         "[<mapname>..] - looks for maplinks at unknown-files",
                                         5,
                                         new[] { TasSayEventArgs.Places.Battle, TasSayEventArgs.Places.Normal }));

            AddMissing(new CommandConfig("modlink",
                                         0,
                                         "[<modname>..] - looks for modlinks at unknown-files",
                                         5,
                                         new[] { TasSayEventArgs.Places.Battle, TasSayEventArgs.Places.Normal }));

            AddMissing(new CommandConfig("id", 2, "<idnumber> [<playername>..] - forces given player to an id"));

            AddMissing(new CommandConfig("team", 2, "<teamnumber> [<playername>..] - forces given player to a team"));

            AddMissing(new CommandConfig("helpall", 0, "- lists all commands known to Springie (sorted by command level)", 5));

            AddMissing(new CommandConfig("fixcolors",
                                         1,
                                         "- changes too similar colors to more different (note that color difference is highly subjective and impossible to model mathematically, so it won't always produce results satisfying for all)",
                                         10));

            AddMissing(new CommandConfig("teamcolors", 1, "- assigns similar colors to allies", 10));

            AddMissing(new CommandConfig("setengine", 2, "[version] - sets a new spring version", 2));

            AddMissing(new CommandConfig("springie",
                                         0,
                                         "- responds with basic springie information",
                                         5,
                                         new[] { TasSayEventArgs.Places.Normal, TasSayEventArgs.Places.Battle, TasSayEventArgs.Places.Channel }));

            AddMissing(new CommandConfig("endvote", 2, "- ends current poll"));

            AddMissing(new CommandConfig("addbox", 1, "<left> <top> <width> <height> [<number>] - adds a new box rectangle"));

            AddMissing(new CommandConfig("clearbox", 1, "[<number>] - removes a box (or removes all boxes if number not specified)"));

            AddMissing(new CommandConfig("listoptions", 1, " - lists all mod/map options", 5));

            AddMissing(new CommandConfig("setoptions", 1, "<name>=<value>[,<name>=<value>] - applies mod/map options", 0));

            AddMissing(new CommandConfig("votesetoptions", 1, "<name>=<value>[,<name>=<value>] - starts a vote to apply mod/map options", 0));

            AddMissing(new CommandConfig("cbalance",
                                         1,
                                         "[<allycount>] - assigns people to allycount random balanced alliances but attempts to put clanmates to same teams",
                                         10));

            AddMissing(new CommandConfig("ban",
                                         4,
                                         "<username> [<duration>] [<reason>...] - bans user username for duration (in minutes) with given reason. Duration 0 = ban for 1000 years",
                                         0));

            AddMissing(new CommandConfig("spawn",
                                         -2,
                                         "<configs> - creates new autohost. Example: !spawn mod=ca:stable,title=My PWN game,password=secret",
                                         0));

            AddMissing(new CommandConfig("unban", 4, "<username> - unbans user", 0));

            AddMissing(new CommandConfig("listbans", 0, "- lists currently banned users", 0));

            AddMissing(new CommandConfig("stats",
                                         0,
                                         "- displays statistics, use this command to get more help",
                                         5,
                                         new[] { TasSayEventArgs.Places.Normal, TasSayEventArgs.Places.Battle, TasSayEventArgs.Places.Channel }));

            AddMissing(new CommandConfig("setpassword", 4, "<newpassword> - sets server password (needs !rehost to apply)"));

            AddMissing(new CommandConfig("setmaxplayers", 4, "<maxplayers> - sets server size (needs !rehost to apply)"));

            AddMissing(new CommandConfig("setgametitle", 4, "<new title> - sets server game title (needs !rehost to apply)"));

            AddMissing(new CommandConfig("boss",
                                         2,
                                         "<name> - sets <name> as a new boss, use without parameter to remove any current boss. If there is a boss on server, other non-admin people have their rights reduced"));

            AddMissing(new CommandConfig("voteboss",
                                         0,
                                         "<name> - sets <name> as a new boss, use without parameter to remove any current boss. If there is a boss on server, other non-admin people have their rights reduced",
                                         0,
                                         new[] { TasSayEventArgs.Places.Normal, TasSayEventArgs.Places.Battle, TasSayEventArgs.Places.Game }));

            AddMissing(new CommandConfig("spec", 2, "<username> - forces player to become spectator", 0));

            AddMissing(new CommandConfig("predict", 0, "predicts chances of victory", 0));

            AddMissing(new CommandConfig("specafk", 1, "forces all AFK player to become spectators", 0));

            AddMissing(new CommandConfig("cheats",
                                         2,
                                         "enables/disables .cheats in game",
                                         0,
                                         new[] { TasSayEventArgs.Places.Normal, TasSayEventArgs.Places.Battle, TasSayEventArgs.Places.Game }));

            AddMissing(new CommandConfig("notify",
                                         0,
                                         "springie notifies you when game ends",
                                         0,
                                         new[]
                                         {
                                             TasSayEventArgs.Places.Normal, TasSayEventArgs.Places.Battle, TasSayEventArgs.Places.Game,
                                             TasSayEventArgs.Places.Channel
                                         }));

            if (config != null && config.CommandLevels != null)
            {
                foreach (var c in config.CommandLevels) {
                    var entry = Commands.FirstOrDefault(x => x.Name == c.Command);
                    if (entry != null) entry.Level = c.Level;
                }
            }
        }


        void AddMissing(CommandConfig command)
        {
            Commands.Add(command);
        }
    }
}