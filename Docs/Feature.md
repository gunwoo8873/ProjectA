
## ScrollBar
```xaml
<ScrollViewer VerticalScrollBarVisibility="Auto" Height="100>
  <!-- ... -->
</ScrollViewer>
```
[!IMPORTANT]
ScrollViewr의 높이 값을 반드시 지정해야 하며, Auto로 지정 시 요소가 적용되지 않게 된다.

```xaml
<ScrollViewer VerticalScrollBarVisibility="Auto" Height="100">
  <ListBox x:Name="listNames" Width="Auto" Height="100"/>
</ScrollViewer>
```