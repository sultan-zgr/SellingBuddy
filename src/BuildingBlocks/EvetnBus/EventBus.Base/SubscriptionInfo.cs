using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBus.Base
{
    public class SubscriptionInfo //Dışarıdan bize gönderilen verinin dışarıda tutulması için kullanıyoruz
    {
        public Type HandlerType { get; set; }

        public SubscriptionInfo(Type handlerType)
        {
            HandlerType = handlerType ?? throw new ArgumentNullException(nameof(handlerType));
        }
        public static SubscriptionInfo Typed(Type handlerType) 
        {
            return new SubscriptionInfo(handlerType);
        }
    }
}
