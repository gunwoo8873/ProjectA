# MenuItem
```xaml
<MenuItem Header="File" />
```

## MenuSelector
```xaml
<Menu x:Name="TopMenuBar" Height="20">
  <!-- File Menu -->
  <MenuItem Header="File">
    <MenuItem Header="New" />
    <MenuItem Header="Open" />
    <MenuItem Header="Save" />
    <MenuItem Header="Save As" />
  </MenuItem>

  <!-- Option menu -->
  <MenuItem Header="Options" />

  <!-- Other menu items -->
  <MenuItem Header="Help">
    <MenuItem Header="About" />
    <MenuItem Header="Source Code" />
  </MenuItem>
</Menu>
```

> [!NOTE]
> 반드시 메뉴바에서 하위 카테고리의 메뉴를 불러오고자 한다면 <Menu>...</Menu> 태그를 붙여야 한다.