<!--
The format of each version's release notes are:

## v[VERSION] - [MONTH] [DAY], [YEAR]

TCD Framework v[VERSION] is available for download and testing.

### New Packages

- **[NEW_PACKAGE_NAME] Package**
  [NEW_PACKAGE_DESCRIPTION]

### New Features

- **[NEW_FEATURE_SUMMARY]**
  [OPTIONAL_NEW_FEATURE_DESCRIPTION]

### Deprecated/Obsolete Features

- **[OBSOLETE_FEATURE]**
  [OBSOLETE_FEATURE_DESCRIPTION]

### Bug Fixes

- **[BUG_FIX_SUMMARY]**

### Improvements/Enhancements

- **[IMPROVEMENT_SUMMARY]**

---

-->

# TCD Framework Release Notes

This file contains release notes for all versions of the TCD Framework, and is ordered from newest to oldest.

---

## v0.4.0 - December 28, 2018

TCD Framework vNext is available for download and testing as NuGet prerelease packages.
For a full list of what's changed since the last release, see [here](https://github.com/tacdevel/tcdfx/compare/v0.3.0...v0.4.0).

### New Packages

- **TCD.Native.Libui**
  The *TCD.Native.Libui* package contains full, unsafe, internal bindings for [andlabs/libui](https://github.com/andlabs/libui). There are no public members in this package, and should not be added directly.

### Deprecated/Obsolete Features

- `TCD.InteropServices.NativeEventArgs` and `TCD.InteropServices.NativeEventHandler` have been removed.  
  *Use `System.EventArgs` and `System.EventHandler` instead.*

### Improvements/Enhancements

- Moved and updated the bindings for `libui` from *TCD.UI*, *TCD.Drawing.Common*, and *TCD.Drawing.Text* to *TCD.Native.Libui*.
- Updated *TCD.UI*, *TCD.Drawing.Common*, and *TCD.Drawing.Text* to use the new *TCD.Native.Libui* package.
- Renamed `TCD.UI.Window.Size` to `TCD.UI.Window.ContentSize`.
- Renamed `TCD.UI.Window.Width` to `TCD.UI.Window.ContentWidth`.
- Renamed `TCD.UI.Window.Height` to `TCD.UI.Window.ContentHeight`.
- Using a new build setup. See (ws.props)[https://github.com/tacdevel/ws.props].
- Updated copyright for 2019.
- Moved all types from `TCD.UI.Controls` and `TCD.UI.Controls.Containers` to `TCD.UI`.

---

## v0.3.0 - December 03, 2018

TCD Framework v0.3.0 is available for download and testing.

### New Packages

- **TCD.Disposable Package**  
  The *TCD.Disposable* package contains the abstract class `TCD.Disposable`. `TCD.Disposable` is a base class for any type that implements `System.IDisposable`. It includes an `IsInvalid` property, as well as a simpler dispose pattern.
- **TCD.Collections.MultiValueDictionary Package**  
  The *TCD.Collections.MultiValueDictionary* package includes the class `TCD.Collections.MultiValueDictionary`. `TCD.Collections.MultiValueDictionary` is a wrapper for a `System.Collections.Generic.Dictionary<TKey, TValue>` that represents a collection of keys and up to five values.
- **TCD.InteropServices Package**  
  The *TCD.InteropServices* package contains classes to help interoperate with unmanaged code easier. The `TCD.InteropServices.NativeAssembly` class is an alternative to the `System.Runtime.InteropServices.DllImportAttribute` and `extern` methods way of doing things. Instead, the `TCD.InteropServices.NativeAssembly` loads the unmanged assembly as a pointer, allowing you to call functions and obtain funtion pointers from the loaded assembly. The `TCD.InteropServices.NativeComponent` classes are designed to serve as a base class for objects that are represented by an `IntPtr` or a `System.Runtime.InteropServices.SafeHandle`. It contains an `IsInvalid`s and `Handle` property, and inherits from `TCD.Disposable`.
- **TCD.UI/TCD.Drawing.Common Packages**  
  The *TCD.UI* and *TCD.Drawing.Common* packages are collectively (soon-to-be) full bindings for the (mid-alpha) [andlabs/libui](https://github.com/andlabs/libui) project. *TCD.UI** includes various classes for UI development, such as `TCD.UI.Application`, `TCD.UI.Window`, and many UI controls and layout containers. *TCD.Drawing.Common* includes classes and controls pertaining to 2D Drawing, such as `TCD.Drawing.Matrix`, `TCD.Drawing.Font`, and `TCD.UI.Controls.ColorPicker`.
- **TCD.Drawing.Primitives Package**  
  The *TCD.Drawing.Primitives* package provides reusable primitive drawing types in the `TCD.Drawing` namespace: `Color`, `Colors` (a collection of predefined colors), `Point`, `PointD`, `Size`, `SizeD`, `Rectangle`, and `RectangleD`.

---