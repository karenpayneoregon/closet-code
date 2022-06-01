# About

Inspired by a forum question were the question was how to group by price of books. Criteria, group by books that are less or equal to ten, books less than or equal to 20 and books for thirty dollars.

:x: Didn’t consider over thirty dollars.

:heavy_check_mark: All code presented accounts for over thirty



What they ended up using

```csharp
decimal cheap = 10;
decimal middle = 20;
decimal expensive = 30;

var result2 = books
    .GroupBy(book => book.Price <= cheap ? cheap : 
        (book.Price > cheap && book.Price <= middle ? middle : expensive))
    .Select(group => (group.Key, group.ToList()))
    .OrderBy(x => x.Key)
    .ToList();
```

Seems to me this is a better solution

```csharp
var results3 = books
    .GroupBy(book => book.Price switch 
    {
        <= 10 => "Cheap",
        > 10 and <= 20 => "Medium",
        _ => "Expensive"
    })
    .ToDictionary(g => g.Key, g => g);
```

Yes this solution hard codes prices but we can also use variables like the first example and still easier to read.

## Thoughts

Outside the code, point here is to know requirements and then think past them for fringe cases or possible modifications to requirements. Follow this by coding in a manner that when coming back to code down the road it is easy to understand without thinking.
