# About

An example for using an `enum` as a property with EF Core.

```csharp
protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

    modelBuilder
        .Entity<Book>()
        .Property(e => e.BookCategory)
        .HasConversion(item => item, 
            item => (int)Enum.Parse(typeof(BookCategory), 
                item.ToString()));

    modelBuilder.HasSequence<int>("seq_test").HasMin(1);

    OnModelCreatingPartial(modelBuilder);
}
```