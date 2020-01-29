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

public class TranslateTransform : Transform {
  internal new static TranslateTransform CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new TranslateTransform(cPtr, cMemoryOwn);
  }

  internal TranslateTransform(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(TranslateTransform obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public TranslateTransform() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    registerExtend = false;
    return NoesisGUI_PINVOKE.new_TranslateTransform__SWIG_0();
  }

  public TranslateTransform(double x, double y) : this(NoesisGUI_PINVOKE.new_TranslateTransform__SWIG_1((float)x, (float)y), true) {
  }

  public static DependencyProperty XProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.TranslateTransform_XProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty YProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.TranslateTransform_YProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public double X {
    set {
      NoesisGUI_PINVOKE.TranslateTransform_X_set(swigCPtr, (float)value);
    } 
    get {
      float ret = NoesisGUI_PINVOKE.TranslateTransform_X_get(swigCPtr);
      return ret;
    } 
  }

  public double Y {
    set {
      NoesisGUI_PINVOKE.TranslateTransform_Y_set(swigCPtr, (float)value);
    } 
    get {
      float ret = NoesisGUI_PINVOKE.TranslateTransform_Y_get(swigCPtr);
      return ret;
    } 
  }

}

}

