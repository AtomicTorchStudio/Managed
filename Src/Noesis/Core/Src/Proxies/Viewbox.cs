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

public class Viewbox : FrameworkElement {
  internal new static Viewbox CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new Viewbox(cPtr, cMemoryOwn);
  }

  internal Viewbox(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(Viewbox obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public Viewbox() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    if ((object)type == typeof(Viewbox)) {
      registerExtend = false;
      return NoesisGUI_PINVOKE.new_Viewbox();
    }
    else {
      return base.CreateExtendCPtr(type, out registerExtend);
    }
  }

  public static DependencyProperty StretchDirectionProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Viewbox_StretchDirectionProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty StretchProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Viewbox_StretchProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public StretchDirection StretchDirection {
    set {
      NoesisGUI_PINVOKE.Viewbox_StretchDirection_set(swigCPtr, (int)value);
    } 
    get {
      StretchDirection ret = (StretchDirection)NoesisGUI_PINVOKE.Viewbox_StretchDirection_get(swigCPtr);
      return ret;
    } 
  }

  public Stretch Stretch {
    set {
      NoesisGUI_PINVOKE.Viewbox_Stretch_set(swigCPtr, (int)value);
    } 
    get {
      Stretch ret = (Stretch)NoesisGUI_PINVOKE.Viewbox_Stretch_get(swigCPtr);
      return ret;
    } 
  }

  public UIElement Child {
    set {
      NoesisGUI_PINVOKE.Viewbox_Child_set(swigCPtr, UIElement.getCPtr(value));
    } 
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Viewbox_Child_get(swigCPtr);
      return (UIElement)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  new internal static IntPtr GetStaticType() {
    IntPtr ret = NoesisGUI_PINVOKE.Viewbox_GetStaticType();
    return ret;
  }

  internal new static IntPtr Extend(string typeName) {
    return NoesisGUI_PINVOKE.Extend_Viewbox(Marshal.StringToHGlobalAnsi(typeName));
  }
}

}

