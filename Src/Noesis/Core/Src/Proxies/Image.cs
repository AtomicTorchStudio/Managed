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

public class Image : FrameworkElement {
  internal new static Image CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new Image(cPtr, cMemoryOwn);
  }

  internal Image(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(Image obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public Image() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    if (type == typeof(Image)) {
      registerExtend = false;
      return NoesisGUI_PINVOKE.new_Image();
    }
    else {
      return base.CreateExtendCPtr(type, out registerExtend);
    }
  }

  public static DependencyProperty SourceProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Image_SourceProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty StretchProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Image_StretchProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty StretchDirectionProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Image_StretchDirectionProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public ImageSource Source {
    set {
      NoesisGUI_PINVOKE.Image_Source_set(swigCPtr, ImageSource.getCPtr(value));
    } 
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Image_Source_get(swigCPtr);
      return (ImageSource)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public Stretch Stretch {
    set {
      NoesisGUI_PINVOKE.Image_Stretch_set(swigCPtr, (int)value);
    } 
    get {
      Stretch ret = (Stretch)NoesisGUI_PINVOKE.Image_Stretch_get(swigCPtr);
      return ret;
    } 
  }

  public StretchDirection StretchDirection {
    set {
      NoesisGUI_PINVOKE.Image_StretchDirection_set(swigCPtr, (int)value);
    } 
    get {
      StretchDirection ret = (StretchDirection)NoesisGUI_PINVOKE.Image_StretchDirection_get(swigCPtr);
      return ret;
    } 
  }

  new internal static IntPtr GetStaticType() {
    IntPtr ret = NoesisGUI_PINVOKE.Image_GetStaticType();
    return ret;
  }

  internal new static IntPtr Extend(string typeName) {
    return NoesisGUI_PINVOKE.Extend_Image(Marshal.StringToHGlobalAnsi(typeName));
  }
}

}

