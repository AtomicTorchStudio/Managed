//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.10
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


using System;
using System.Runtime.InteropServices;

namespace Noesis
{

public class Canvas : Panel {
  internal new static Canvas CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new Canvas(cPtr, cMemoryOwn);
  }

  internal Canvas(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(Canvas obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public Canvas() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    if (type == typeof(Canvas)) {
      registerExtend = false;
      return NoesisGUI_PINVOKE.new_Canvas();
    }
    else {
      return base.CreateExtendCPtr(type, out registerExtend);
    }
  }

  public static double GetLeft(UIElement element) {
    if (element == null) throw new ArgumentNullException("element");
    {
      double ret = NoesisGUI_PINVOKE.Canvas_GetLeft(UIElement.getCPtr(element));
      return ret;
    }
  }

  public static void SetLeft(UIElement element, double left) {
    if (element == null) throw new ArgumentNullException("element");
    {
      NoesisGUI_PINVOKE.Canvas_SetLeft(UIElement.getCPtr(element), (float)left);
    }
  }

  public static double GetTop(UIElement element) {
    if (element == null) throw new ArgumentNullException("element");
    {
      double ret = NoesisGUI_PINVOKE.Canvas_GetTop(UIElement.getCPtr(element));
      return ret;
    }
  }

  public static void SetTop(UIElement element, double top) {
    if (element == null) throw new ArgumentNullException("element");
    {
      NoesisGUI_PINVOKE.Canvas_SetTop(UIElement.getCPtr(element), (float)top);
    }
  }

  public static double GetRight(UIElement element) {
    if (element == null) throw new ArgumentNullException("element");
    {
      double ret = NoesisGUI_PINVOKE.Canvas_GetRight(UIElement.getCPtr(element));
      return ret;
    }
  }

  public static void SetRight(UIElement element, double right) {
    if (element == null) throw new ArgumentNullException("element");
    {
      NoesisGUI_PINVOKE.Canvas_SetRight(UIElement.getCPtr(element), (float)right);
    }
  }

  public static double GetBottom(UIElement element) {
    if (element == null) throw new ArgumentNullException("element");
    {
      double ret = NoesisGUI_PINVOKE.Canvas_GetBottom(UIElement.getCPtr(element));
      return ret;
    }
  }

  public static void SetBottom(UIElement element, double bottom) {
    if (element == null) throw new ArgumentNullException("element");
    {
      NoesisGUI_PINVOKE.Canvas_SetBottom(UIElement.getCPtr(element), (float)bottom);
    }
  }

  public static DependencyProperty BottomProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Canvas_BottomProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty LeftProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Canvas_LeftProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty RightProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Canvas_RightProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty TopProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Canvas_TopProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  new internal static IntPtr GetStaticType() {
    IntPtr ret = NoesisGUI_PINVOKE.Canvas_GetStaticType();
    return ret;
  }

  internal new static IntPtr Extend(string typeName) {
    return NoesisGUI_PINVOKE.Extend_Canvas(Marshal.StringToHGlobalAnsi(typeName));
  }
}

}

