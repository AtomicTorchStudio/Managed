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

[StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
public struct Thickness {

  [MarshalAs(UnmanagedType.R4)]
  private float _l;

  [MarshalAs(UnmanagedType.R4)]
  private float _t;

  [MarshalAs(UnmanagedType.R4)]
  private float _r;

  [MarshalAs(UnmanagedType.R4)]
  private float _b;

  public double Left {
    get { return this._l; }
    set { this._l = (float)value; }
  }

  public double Top {
    get { return this._t; }
    set { this._t = (float)value; }
  }

  public double Right {
    get { return this._r; }
    set { this._r = (float)value; }
  }

  public double Bottom {
    get { return this._b; }
    set { this._b = (float)value; }
  }

  public Size Size {
    get { return new Size(Left + Right, Top + Bottom); }
  }

  public Thickness(double size) : this(size, size, size, size) {
  }

  public Thickness(double left, double top, double right, double bottom) {
    this._l = (float)left;
    this._t = (float)top;
    this._r = (float)right;
    this._b = (float)bottom;
  }

  public Thickness(float size) : this(size, size, size, size) {
  }

  public Thickness(float lr, float tb) : this(lr, tb, lr, tb)  {
  }

  public Thickness(float left, float top, float right, float bottom) {
    this._l = left;
    this._t = top;
    this._r = right;
    this._b = bottom;
  }

  public static bool operator==(Thickness t0, Thickness t1) {
    return t0.Left == t1.Left && t0.Top == t1.Top && t0.Right == t1.Right && t0.Bottom == t1.Bottom;
  }

  public static bool operator!=(Thickness t0, Thickness t1) {
    return !(t0 == t1);
  }

  public override bool Equals(System.Object obj) {
    return obj is Thickness && this == (Thickness)obj;
  }

  public bool Equals(Thickness t) {
    return this == t;
  }

  public override int GetHashCode() {
    return ((Left.GetHashCode() ^ Top.GetHashCode()) ^ Right.GetHashCode()) ^ Bottom.GetHashCode();
  }

  public override string ToString() {
    if (Left == Top && Left == Right && Left == Bottom) {
      return String.Format("{0}", Left);
    }
    else if (Left == Right && Top == Bottom) {
      return String.Format("{0},{1}", Left, Top);
    }
    else {
      return String.Format("{0},{1},{2},{3}", Left, Top, Right, Bottom);
    }
  }

  public static Thickness Parse(string str) {
    Thickness thickness;
    if (Thickness.TryParse(str, out thickness)) {
      return thickness;
    }
    throw new ArgumentException("Cannot create Thickness from '" + str + "'");
  }

  public static bool TryParse(string str, out Thickness result) {
    bool ret = NoesisGUI_PINVOKE.Thickness_TryParse(str != null ? str : string.Empty, out result);
    return ret;
  }

}

}

