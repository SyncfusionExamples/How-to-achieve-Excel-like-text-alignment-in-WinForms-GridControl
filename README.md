# How-to-achieve-Excel-like-text-alignment-in-WinForms-GridControl

By default, text alignment in grid control is right aligned for both alphabets and numeric. In order to achieve excel like alignment, make use of [WinForms Grid](https://www.syncfusion.com/winforms-ui-controls/grid-control) ExcelLikeAlignment property. So, the string values will be aligned left side and numeric values will be aligned right side of the cell.

Code Snippet

C#
```
this.gridControl1.ExcelLikeAlignment = true;
```

VB
```
Me.gridControl1.ExcelLikeAlignment = True
```

Screenshot

![Showing text alignment in GridControl](ExcelLikeTextAlignment.png)

[View sample in GitHub](https://github.com/SyncfusionExamples/How-to-achieve-Excel-like-text-alignment-in-WinForms-GridControl)
