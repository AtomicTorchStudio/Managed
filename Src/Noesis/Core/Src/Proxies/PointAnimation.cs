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

public class PointAnimation : BaseAnimation {
  internal new static PointAnimation CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new PointAnimation(cPtr, cMemoryOwn);
  }

  internal PointAnimation(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(PointAnimation obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public PointAnimation() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    registerExtend = false;
    return NoesisGUI_PINVOKE.new_PointAnimation();
  }

  public static DependencyProperty ByProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.PointAnimation_ByProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty FromProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.PointAnimation_FromProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty ToProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.PointAnimation_ToProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public Nullable<Point> From {
    set {
      NullablePoint tempvalue = value;
      NoesisGUI_PINVOKE.PointAnimation_From_set(swigCPtr, ref tempvalue);
    }

    get {
      IntPtr ret = NoesisGUI_PINVOKE.PointAnimation_From_get(swigCPtr);
      if (ret != IntPtr.Zero) {
        return Marshal.PtrToStructure<NullablePoint>(ret);
      }
      else {
        return new Nullable<Point>();
      }
    }

  }

  public Nullable<Point> To {
    set {
      NullablePoint tempvalue = value;
      NoesisGUI_PINVOKE.PointAnimation_To_set(swigCPtr, ref tempvalue);
    }

    get {
      IntPtr ret = NoesisGUI_PINVOKE.PointAnimation_To_get(swigCPtr);
      if (ret != IntPtr.Zero) {
        return Marshal.PtrToStructure<NullablePoint>(ret);
      }
      else {
        return new Nullable<Point>();
      }
    }

  }

  public Nullable<Point> By {
    set {
      NullablePoint tempvalue = value;
      NoesisGUI_PINVOKE.PointAnimation_By_set(swigCPtr, ref tempvalue);
    }

    get {
      IntPtr ret = NoesisGUI_PINVOKE.PointAnimation_By_get(swigCPtr);
      if (ret != IntPtr.Zero) {
        return Marshal.PtrToStructure<NullablePoint>(ret);
      }
      else {
        return new Nullable<Point>();
      }
    }

  }

}

}

