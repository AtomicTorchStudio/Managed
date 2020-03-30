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

public class CompositeTransform : Transform {
  internal new static CompositeTransform CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new CompositeTransform(cPtr, cMemoryOwn);
  }

  internal CompositeTransform(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(CompositeTransform obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public CompositeTransform() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    registerExtend = false;
    return NoesisGUI_PINVOKE.new_CompositeTransform();
  }

  public static DependencyProperty CenterXProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.CompositeTransform_CenterXProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty CenterYProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.CompositeTransform_CenterYProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty RotationProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.CompositeTransform_RotationProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty ScaleXProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.CompositeTransform_ScaleXProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty ScaleYProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.CompositeTransform_ScaleYProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty SkewXProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.CompositeTransform_SkewXProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty SkewYProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.CompositeTransform_SkewYProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty TranslateXProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.CompositeTransform_TranslateXProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty TranslateYProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.CompositeTransform_TranslateYProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public double CenterX {
    set {
      NoesisGUI_PINVOKE.CompositeTransform_CenterX_set(swigCPtr, (float)value);
    } 
    get {
      float ret = NoesisGUI_PINVOKE.CompositeTransform_CenterX_get(swigCPtr);
      return ret;
    } 
  }

  public double CenterY {
    set {
      NoesisGUI_PINVOKE.CompositeTransform_CenterY_set(swigCPtr, (float)value);
    } 
    get {
      float ret = NoesisGUI_PINVOKE.CompositeTransform_CenterY_get(swigCPtr);
      return ret;
    } 
  }

  public double Rotation {
    set {
      NoesisGUI_PINVOKE.CompositeTransform_Rotation_set(swigCPtr, (float)value);
     } 
    get {
      float ret = NoesisGUI_PINVOKE.CompositeTransform_Rotation_get(swigCPtr);
      return ret;
    } 
  }

  public double ScaleX {
    set {
      NoesisGUI_PINVOKE.CompositeTransform_ScaleX_set(swigCPtr, (float)value);
    } 
    get {
      float ret = NoesisGUI_PINVOKE.CompositeTransform_ScaleX_get(swigCPtr);
      return ret;
    } 
  }

  public double ScaleY {
    set {
      NoesisGUI_PINVOKE.CompositeTransform_ScaleY_set(swigCPtr, (float)value);
    } 
    get {
      float ret = NoesisGUI_PINVOKE.CompositeTransform_ScaleY_get(swigCPtr);
      return ret;
    } 
  }

  public double SkewX {
    set {
      NoesisGUI_PINVOKE.CompositeTransform_SkewX_set(swigCPtr, (float)value);
    } 
    get {
      float ret = NoesisGUI_PINVOKE.CompositeTransform_SkewX_get(swigCPtr);
      return ret;
    } 
  }

  public double SkewY {
    set {
      NoesisGUI_PINVOKE.CompositeTransform_SkewY_set(swigCPtr, (float)value);
    } 
    get {
      float ret = NoesisGUI_PINVOKE.CompositeTransform_SkewY_get(swigCPtr);
      return ret;
    } 
  }

  public double TranslateX {
    set {
      NoesisGUI_PINVOKE.CompositeTransform_TranslateX_set(swigCPtr, (float)value);
    } 
    get {
      float ret = NoesisGUI_PINVOKE.CompositeTransform_TranslateX_get(swigCPtr);
      return ret;
    } 
  }

  public double TranslateY {
    set {
      NoesisGUI_PINVOKE.CompositeTransform_TranslateY_set(swigCPtr, (float)value);
    } 
    get {
      float ret = NoesisGUI_PINVOKE.CompositeTransform_TranslateY_get(swigCPtr);
      return ret;
    } 
  }

}

}

