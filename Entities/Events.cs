﻿using System;

namespace Neon.Entities {
    /// <summary>
    /// Wraps a common event pattern where there is only one instance of the event.
    /// </summary>
    /// <typeparam name="DerivedEventType">The type of the class that derives this type.</typeparam>
    public class SingletonEvent<DerivedEventType> : IEvent
        where DerivedEventType : SingletonEvent<DerivedEventType>, new() {

        /// <summary>
        /// Internal constructor to prevent more instances of the singleton event type from being
        /// created.
        /// </summary>
        protected SingletonEvent() {
        }

        /// <summary>
        /// The event's instance.
        /// </summary>
        public static DerivedEventType Instance = new DerivedEventType();
    }

    /// <summary>
    /// Event that notifies listener that a new data instance has been added to the entity.
    /// </summary>
    public class AddedDataEvent : IEvent {
        /// <summary>
        /// The type of data that has been added.
        /// </summary>
        public Type AddedDataType;

        /// <summary>
        /// Initializes a new instance of the AddedDataEvent class.
        /// </summary>
        /// <param name="addedDataType">Type of the added data.</param>
        internal AddedDataEvent(Type addedDataType) {
            AddedDataType = addedDataType;
        }
    }

    /// <summary>
    /// Event that notifies listener that a new data instance has been added to the entity.
    /// </summary>
    public class RemovedDataEvent : IEvent {
        /// <summary>
        /// The type of data that has been added.
        /// </summary>
        public Type RemovedDataType;

        /// <summary>
        /// Initializes a new instance of the RemovedDataEvent class.
        /// </summary>
        /// <param name="removedDataType">Type of the removed data.</param>
        internal RemovedDataEvent(Type removedDataType) {
            RemovedDataType = removedDataType;
        }
    }

    /// <summary>
    /// Event notifying listeners that the entity should be hidden.
    /// </summary>
    public class HideEntityEvent : SingletonEvent<HideEntityEvent> { }

    /// <summary>
    /// Event notifying listeners that the entity should be visible.
    /// </summary>
    public class ShowEntityEvent : SingletonEvent<ShowEntityEvent> { }

    /// <summary>
    /// Event notifying listeners that the entity has been destroyed.
    /// </summary>
    public class DestroyedEntityEvent : SingletonEvent<DestroyedEntityEvent> { }
}