namespace SCbuggybits.Commands
{
    using Sitecore;
    using Sitecore.Data;
    using Sitecore.Data.Items;
    using Sitecore.Diagnostics;
    using Sitecore.Shell.Framework.Commands;
    
    public class CEDemoCommand : Command
    {
        public override void Execute([NotNull] CommandContext context)
        {
            // When this command executes
        }

        /// <summary>
        /// This method gets called on each Item selection
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public override CommandState QueryState(CommandContext context)
        {
            // This method decides whether to execute this command or not
            if (context.Items != null && context.Items.Length > 0)
            {
                var currentItem = context.Items[0];
                if (currentItem != null && currentItem.Name == "SlowDownCE")
                {
                    IsRequiredToBeEnabled();
                }

            }
            return base.QueryState(context);
        }

        private static void IsRequiredToBeEnabled()
        {
            // To Demo long executing task
            var timeSpan = System.TimeSpan.FromSeconds(4);            
            System.Threading.Thread.Sleep(timeSpan);
        }
    }
}