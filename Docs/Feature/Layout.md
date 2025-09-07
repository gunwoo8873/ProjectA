# Grid
```xaml
<Grid Margin="5">
  <!-- Column Layout -->
  <Grid.ColumnDefinitions>
    <ColumnDefinition Width="*" /> <!-- 0 -->
    <ColumnDefinition Width="*" /> <!-- 1 -->
    <ColumnDefinition Width="*" /> <!-- 2 -->
  </Grid.ColumnDefinitions>

  <!-- Row Layout -->
  <Grid.RowDefinitions>
    <RowDefinition Height="*" /> <!-- 0 -->
    <RowDefinition Height="*" /> <!-- 1 -->
    <RowDefinition Height="*" /> <!-- 2 -->
  </Grid.RowDefinitions>

  <StackPanel Grid.Row="0" Grid.Column="0" Margin="5,0,0,0">
    <!-- ... -->
  </StackPanel>

  <StackPanel Grid.Row="0" Grid.Column="1" Margin="5,0,0,0">
    <!-- ... -->
  </StackPanel>

  <StackPanel Grid.Row="1" Grid.Column="1" Margin="5,0,0,0">
    <!-- ... -->
  </StackPanel>
</Grid>
```