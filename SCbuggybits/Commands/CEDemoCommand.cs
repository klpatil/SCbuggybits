namespace SCbuggybits.Commands
{
    using Sitecore;
    using Sitecore.Data;
    using Sitecore.Data.Items;
    using Sitecore.Diagnostics;
    using Sitecore.Shell.Framework.Commands;

    // TODO: \App_Config\include\CEDemoCommand.config created automatically when creating CEDemoCommand class. In this config include file, specify command name attribute value

    public class CEDemoCommand : Command
    {
        public override void Execute([NotNull] CommandContext context)
        {
            // When this command executes
        }

        public override CommandState QueryState(CommandContext context)
        {
            // This method decides whether to execute this command or not
            if (context.Items != null && context.Items.Length > 0)
            {
                var currentItem = context.Items[0];
                if (currentItem != null && currentItem.Name == "SlowDownCE")
                {
                    var timeSpan = System.TimeSpan.FromMinutes(1);
                    // To Demo one minute long executing task
                    System.Threading.Thread.Sleep(timeSpan);

                }
                    
            }
            return base.QueryState(context);
        }
    }
}