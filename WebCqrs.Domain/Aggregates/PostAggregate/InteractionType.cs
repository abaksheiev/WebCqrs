﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCqrs.Domain.Aggregates.PostAggregate
{
    public enum InteractionType
    {
        Like,
        Dislike,
        Haha,
        Wow,
        Love,
        Angry
    }
}
