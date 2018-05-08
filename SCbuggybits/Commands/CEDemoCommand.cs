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

        public override CommandState QueryState(CommandContext context)
        {
            // This method decides whether to execute this command or not
            if (context.Items != null && context.Items.Length > 0)
            {
                var currentItem = context.Items[0];
                if (currentItem != null && currentItem.Name == "SlowDownCE")
                {
                    var timeSpan = System.TimeSpan.FromSeconds(10);
                    // To Demo long executing task
                    System.Threading.Thread.Sleep(timeSpan);

                }
                    
            }
            return base.QueryState(context);
        }
    }
}