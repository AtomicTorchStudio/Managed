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

public class ScaleTransform : Transform {
  internal new static ScaleTransform CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new ScaleTransform(cPtr, cMemoryOwn);
  }

  internal ScaleTransform(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(ScaleTransform obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public ScaleTransform() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    registerExtend = false;
    return NoesisGUI_PINVOKE.new_ScaleTransform__SWIG_0();
  }

  public ScaleTransform(double scaleX, double scaleY) : this(NoesisGUI_PINVOKE.new_ScaleTransform__SWIG_1((float)scaleX, (float)scaleY), true) {
  }

  public static DependencyProperty CenterXProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ScaleTransform_CenterXProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty CenterYProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ScaleTransform_CenterYProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty ScaleXProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ScaleTransform_ScaleXProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty ScaleYProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ScaleTransform_ScaleYProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public double ScaleX {
    set {
      NoesisGUI_PINVOKE.ScaleTransform_ScaleX_set(swigCPtr, (float)value);
    } 
    get {
      double ret = NoesisGUI_PINVOKE.ScaleTransform_ScaleX_get(swigCPtr);
      return ret;
    } 
  }

  public double ScaleY {
    set {
      NoesisGUI_PINVOKE.ScaleTransform_ScaleY_set(swigCPtr, (float)value);
    } 
    get {
      double ret = NoesisGUI_PINVOKE.ScaleTransform_ScaleY_get(swigCPtr);
      return ret;
    } 
  }

  public double CenterX {
    set {
      NoesisGUI_PINVOKE.ScaleTransform_CenterX_set(swigCPtr, (float)value);
    } 
    get {
      double ret = NoesisGUI_PINVOKE.ScaleTransform_CenterX_get(swigCPtr);
      return ret;
    } 
  }

  public double CenterY {
    set {
      NoesisGUI_PINVOKE.ScaleTransform_CenterY_set(swigCPtr, (float)value);
    } 
    get {
      double ret = NoesisGUI_PINVOKE.ScaleTransform_CenterY_get(swigCPtr);
      return ret;
    } 
  }

  new internal static IntPtr GetStaticType() {
    IntPtr ret = NoesisGUI_PINVOKE.ScaleTransform_GetStaticType();
    return ret;
  }

}

}

