using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;

namespace DungeonDrone.Modules
{
    public class Commands : ModuleBase<SocketCommandContext>
    {
        private Random randomgen = new Random();

        [Command("ping")]
        public async Task Ping()
        {
           await ReplyAsync("Pong");
        }


        [Command("roll d20")]
        public async Task RollD20()
        {
            int result = randomgen.Next(1, 21);
            await ReplyAsync(result.ToString());
        }

    }
}
