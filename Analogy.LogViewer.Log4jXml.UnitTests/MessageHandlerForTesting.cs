﻿using Analogy.Interfaces;
using Analogy.Interfaces.DataTypes;
using System.Collections.Generic;

namespace Analogy.LogViewer.PowerToys.UnitTests
{
    class MessageHandlerForTesting : ILogMessageCreatedHandler
    {
        private List<IAnalogyLogMessage> messages;
        public MessageHandlerForTesting()
        {
            messages = new List<IAnalogyLogMessage>();
        }
        public void AppendMessage(IAnalogyLogMessage message, string dataSource)
        {
            messages.Add(message);
        }

        public void AppendMessages(List<IAnalogyLogMessage> messages, string dataSource)
        {
            this.messages.AddRange(messages);
        }

        public void ReportFileReadProgress(AnalogyFileReadProgress progress)
        {
            //noop
        }

        public bool ForceNoFileCaching { get; set; }
        public bool DoNotAddToRecentHistory { get; set; }
    }
}
