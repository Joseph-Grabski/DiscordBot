using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;
using Discord;
using Discord.WebSocket;

namespace DiscordBot.Modules
{
    public class Meme : ModuleBase<SocketCommandContext>
    {

        //Context.User;
        //Context.Client;
        //Context.Guild;
        //Context.Message;
        //Context.Channel;

        //EmbedBuilder builder = new EmbedBuilder();
        //builder.AddInlineField("Hello there!", Context.User.ToString())
        //    .WithColor(Color.Green);

        //await ReplyAsync("", false, builder.Build());

        

        [Command("noob")]
        public async Task MessageAsync(string name = "")
        {
            if (name == "")
            {
                await ReplyAsync($"{Context.User.Mention} is a noob!");
            }
            else
            {
                await ReplyAsync($"{name} is a noob!");
            }
            
        }

        [Command("slap")]
        public async Task SlapAsync(SocketGuildUser target, int force = 0)
        {
            switch (force)
            {
                case 1:
                    await ReplyAsync($"{Context.User.Mention} lightly slapped {target.Mention} :clap:");
                    break;
                case 2:
                    await ReplyAsync($"{Context.User.Mention} slapped {target.Mention} with vigour! :clap:");
                    break;
                case 3:
                    await ReplyAsync($"{Context.User.Mention} falcon punched {target.Mention}, knocking them out :clap:");
                    break;
                default:
                    await ReplyAsync($"{Context.User.Mention} slapped {target.Mention} :clap:");
                    break;
            }
            
        }

        [Command("betterbot")]
        public async Task BotAsync()
        {
            await ReplyAsync("Joe's bot is better!");
        }
    }
}
