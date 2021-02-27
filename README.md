# space-explorer

I've been doing this all wrong...

- MonoBehaviors aren't full objects. They're actions on an object.
- MonoBehaviors can't be created w/ "new"
- I need to create objects (and set up their specs) in a totally different startup script and then apply the MonoBehavior to all of them.