/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.4
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace BerkeleyDB.Internal {

using System;
using System.Runtime.InteropServices;

internal class DB_LSN : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal DB_LSN(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(DB_LSN obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~DB_LSN() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          libdb_csharpPINVOKE.delete_DB_LSN(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  internal uint file {
    set {
      libdb_csharpPINVOKE.DB_LSN_file_set(swigCPtr, value);
    } 
    get {
      uint ret = libdb_csharpPINVOKE.DB_LSN_file_get(swigCPtr);
      return ret;
    } 
  }

  internal uint offset {
    set {
      libdb_csharpPINVOKE.DB_LSN_offset_set(swigCPtr, value);
    } 
    get {
      uint ret = libdb_csharpPINVOKE.DB_LSN_offset_get(swigCPtr);
      return ret;
    } 
  }

  internal DB_LSN() : this(libdb_csharpPINVOKE.new_DB_LSN(), true) {
  }

}

}
