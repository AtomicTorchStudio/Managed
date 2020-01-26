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

public class Transform3D : Animatable {
  internal new static Transform3D CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new Transform3D(cPtr, cMemoryOwn);
  }

  internal Transform3D(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(Transform3D obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  protected Transform3D() {
  }

  public virtual Matrix3D GetTransform(Size size) {
    IntPtr ret = NoesisGUI_PINVOKE.Transform3D_GetTransform(swigCPtr, ref size);
    if (ret != IntPtr.Zero) {
      return Marshal.PtrToStructure<Matrix3D>(ret);
    }
    else {
      return Matrix3D.Identity;
    }
  }

}

}

