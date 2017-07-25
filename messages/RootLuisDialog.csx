    #load "Message.csx"
	using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Web;
    using Microsoft.Bot.Builder.Dialogs;
    using Microsoft.Bot.Builder.FormFlow;
    using Microsoft.Bot.Builder.Luis;
    using Microsoft.Bot.Builder.Luis.Models;
    using Microsoft.Bot.Connector;

    [LuisModel("3c78a3b9-abfd-4d9f-98c3-61f6914b3c02", "d0bd43b0dc6e4bdba47b5d1971546462")]
    [Serializable]
    public class RootLuisDialog : LuisDialog<object>
    {
        [LuisIntent("")]
        [LuisIntent("None")]
        public async Task EmailReadRate(IDialogContext context, LuisResult result)
        {
            string message = $"Sorry, I did not understand '{result.Query}'. Type 'help' if you need assistance.";

            await context.PostAsync(message);

            context.Wait(this.MessageReceived);
        }

        [LuisIntent("email read rate")]
        public async Task Reviews(IDialogContext context, LuisResult result)
        {
            string message = $"EmailReadRate";

            await context.PostAsync(message);

            context.Wait(this.MessageReceived);
        }
    }