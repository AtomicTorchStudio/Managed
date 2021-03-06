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

public class RotateTransform : Transform {
  internal new static RotateTransform CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new RotateTransform(cPtr, cMemoryOwn);
  }

  internal RotateTransform(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(RotateTransform obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public RotateTransform() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    registerExtend = false;
    return NoesisGUI_PINVOKE.new_RotateTransform__SWIG_0();
  }

  public RotateTransform(double angle) : this(NoesisGUI_PINVOKE.new_RotateTransform__SWIG_1((float)angle), true) {
  }

  public static DependencyProperty AngleProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.RotateTransform_AngleProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty CenterXProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.RotateTransform_CenterXProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty CenterYProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.RotateTransform_CenterYProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public double Angle {
    set {
      NoesisGUI_PINVOKE.RotateTransform_Angle_set(swigCPtr, (float)value);
    } 
    get {
      double ret = NoesisGUI_PINVOKE.RotateTransform_Angle_get(swigCPtr);
      return ret;
    } 
  }

  public double CenterX {
    set {
      NoesisGUI_PINVOKE.RotateTransform_CenterX_set(swigCPtr, (float)value);
    } 
    get {
      double ret = NoesisGUI_PINVOKE.RotateTransform_CenterX_get(swigCPtr);
      return ret;
    } 
  }

  public double CenterY {
    set {
      NoesisGUI_PINVOKE.RotateTransform_CenterY_set(swigCPtr, (float)value);
    } 
    get {
      double ret = NoesisGUI_PINVOKE.RotateTransform_CenterY_get(swigCPtr);
      return ret;
    } 
  }

  new internal static IntPtr GetStaticType() {
    IntPtr ret = NoesisGUI_PINVOKE.RotateTransform_GetStaticType();
    return ret;
  }

}

}

