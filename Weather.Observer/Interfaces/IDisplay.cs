using System;
using System.Collections.Generic;

using System;
using Weather.Observer;
using Weather.Observer.Factory;

using Weather.Observer.Singleton;
using Weather.Observer.Observers;

namespace Weather.Observer.Interfaces

{
    /// <summary>
    /// Interface for all display elements.
    /// </summary>
    public interface IDisplay
    {
        void Display();
    }
}
