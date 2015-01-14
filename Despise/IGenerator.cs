﻿using System;

namespace Despise
{
    public interface IGenerator<out T>
    {
        Random Random { get; }
        T Generate();
        T[] GenerateMany(int number);
    }
}