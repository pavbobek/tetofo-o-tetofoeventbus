# Event Bus

> Simple implementation of interservice communication. Any component can push various event to the event bus. Component can as well subscribe for various Events via callback subscribtion in IOCContainer. Multiple containers are capable of comunicate via this pattern as well.

# Stage 1

> Basic component declaration and definition.
> - IEventBus - staging events.
> - IEvent - used event.
> - ICallback - event subscription.
> - IAuthor - source of event.
