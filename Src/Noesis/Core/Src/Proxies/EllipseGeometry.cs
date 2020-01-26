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

public class EllipseGeometry : Geometry {
  internal new static EllipseGeometry CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new EllipseGeometry(cPtr, cMemoryOwn);
  }

  internal EllipseGeometry(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(EllipseGeometry obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public EllipseGeometry() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    registerExtend = false;
    return NoesisGUI_PINVOKE.new_EllipseGeometry__SWIG_0();
  }

  public EllipseGeometry(Point center, float rX, float rY) : this(NoesisGUI_PINVOKE.new_EllipseGeometry__SWIG_1(ref center, rX, rY), true) {
  }

  public override bool IsEmpty() {
    bool ret = NoesisGUI_PINVOKE.EllipseGeometry_IsEmpty(swigCPtr);
    return ret;
  }

  public static DependencyProperty CenterProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.EllipseGeometry_CenterProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty RadiusXProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.EllipseGeometry_RadiusXProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty RadiusYProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.EllipseGeometry_RadiusYProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public Point Center {
    set {
      NoesisGUI_PINVOKE.EllipseGeometry_Center_set(swigCPtr, ref value);
    }

    get {
      IntPtr ret = NoesisGUI_PINVOKE.EllipseGeometry_Center_get(swigCPtr);
      if (ret != IntPtr.Zero) {
        return Marshal.PtrToStructure<Point>(ret);
      }
      else {
        return new Point();
      }
    }

  }

  public double RadiusX {
    set {
      NoesisGUI_PINVOKE.EllipseGeometry_RadiusX_set(swigCPtr, (float)value);
    } 
    get {
      float ret = NoesisGUI_PINVOKE.EllipseGeometry_RadiusX_get(swigCPtr);
      return ret;
    } 
  }

  public double RadiusY {
    set {
      NoesisGUI_PINVOKE.EllipseGeometry_RadiusY_set(swigCPtr, (float)value);
    } 
    get {
      float ret = NoesisGUI_PINVOKE.EllipseGeometry_RadiusY_get(swigCPtr);
      return ret;
    } 
  }

}

}

