using Elsa.Features.Abstractions;
using Elsa.Features.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Elsa.RabbitMq.Features;

public class RabbitMqFeature : FeatureBase
{
    public RabbitMqFeature(IModule module) : base(module)
    {
    }
}
