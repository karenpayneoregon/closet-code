# Owned Entity Types

[![](https://img.shields.io/badge/EF%20Core-Code-green)]()

EF Core allows you to model entity types that can only ever appear on navigation properties of other entity types. These are called owned entity types. The entity containing an owned entity type is its owner.

Owned entities are essentially a part of the owner and cannot exist without it, they are conceptually similar to aggregates. This means that the owned entity is by definition on the dependent side of the relationship with the owner.

[Microsoft docs](https://docs.microsoft.com/en-us/ef/core/modeling/owned-entities)

[Original source code](https://github.com/dotnet/EntityFramework.Docs/tree/main/samples/core/Modeling/OwnedEntities)