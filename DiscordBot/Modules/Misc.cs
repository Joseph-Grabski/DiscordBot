using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;
using Discord;
using Discord.WebSocket;
using System.IO;

namespace DiscordBot.Modules
{
    public class Misc : ModuleBase<SocketCommandContext>
    {
        [Command("repeat")]
        public async Task RepeatAsync([Remainder] string content)
        {
            await ReplyAsync($"{content}");
        }

        [Command("choose")]
        public async Task ChooseAsync([Remainder] string message)
        {
            string[] options = message.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

            Random r = new Random();
            string selection = options[r.Next(0, options.Length)];

            EmbedBuilder builder = new EmbedBuilder();
            builder.AddField("I have chosen!", selection)
                .WithColor(Color.Gold);
            builder.WithThumbnailUrl("http://www.mrtownsend.com/icons/es.jpg");

            await ReplyAsync("", false, builder.Build());
        }

        [Command("hi")]
        public async Task HelloAsync()
        {
            await ReplyAsync($"Hi there {Context.User.Mention}!");
        }
    }
}
