# About

Example for EF Core `HasConversion` for `enum`

```csharp
var programmingBooks = bookList
    .Where(books => books.BookVariantId == BookVariantId.Programming)
    .ToList();
```
</br>

![Screen Shot](assets/ScreenShot.png)

</br>

**Debug view**

![Screen Shot1](assets/ScreenShot1.png)