using System;
using System.Collections.Generic;
using System.Text;

namespace CorePool.Api.WebSocketNotifications
{
    public enum WsNotificationType
    {
        Greeting,
        BlockFound,
        NewChainHeight,
        Payment,
        BlockUnlocked,
        BlockUnlockProgress,
        HashrateUpdated
    }
}
