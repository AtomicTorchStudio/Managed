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

public class SplineRectKeyFrame : RectKeyFrame {
  internal new static SplineRectKeyFrame CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new SplineRectKeyFrame(cPtr, cMemoryOwn);
  }

  internal SplineRectKeyFrame(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(SplineRectKeyFrame obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public SplineRectKeyFrame() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    registerExtend = false;
    return NoesisGUI_PINVOKE.new_SplineRectKeyFrame();
  }

  public static DependencyProperty KeySplineProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.SplineRectKeyFrame_KeySplineProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public KeySpline KeySpline {
    set {
      NoesisGUI_PINVOKE.SplineRectKeyFrame_KeySpline_set(swigCPtr, KeySpline.getCPtr(value));
    } 
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.SplineRectKeyFrame_KeySpline_get(swigCPtr);
      return (KeySpline)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

}

}

