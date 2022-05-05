# About

This project demonstrates asynchronous vs synchronous coding. Done in a Forms project rather than a console project as it’s easier to feel the difference. 

So, for both web and desktop applications go asynchronous and when appropriate provide an option to cancel or a cancel timeout.

Simple timeout, see [the following](https://social.technet.microsoft.com/wiki/contents/articles/54260.sql-server-freezes-when-connecting-c.aspx) for actual usage.


```csharp
private const int TimeOutSeconds = 5;
/// <summary>
/// Pass the time-out for wait period for the connection. For more on time-out see the following
/// 
/// </summary>
private CancellationTokenSource _cancellationTokenSource = new(TimeSpan.FromSeconds(TimeOutSeconds));
```