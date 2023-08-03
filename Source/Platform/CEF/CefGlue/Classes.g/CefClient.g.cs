﻿//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
namespace Xilium.CefGlue
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.InteropServices;
    using System.Threading;
    using Xilium.CefGlue.Interop;
    
    // Role: HANDLER
    public abstract unsafe partial class CefClient
    {
        private static Dictionary<IntPtr, CefClient> _roots = new Dictionary<IntPtr, CefClient>();
        
        private int _refct;
        private cef_client_t* _self;
        
        internal static CefClient FromNativeOrNull(cef_client_t* ptr)
        {
            CefClient value = null;
            bool found;
            lock (_roots)
            {
                found = _roots.TryGetValue((IntPtr)ptr, out value);
                // as we're getting the ref from the outside, it's our responsibility to decrement it
                value.release(ptr);
            }
            return found ? value : null;
        }
        
        internal static CefClient FromNative(cef_client_t* ptr)
        {
            var value = FromNativeOrNull(ptr);
            if (value == null) throw ExceptionBuilder.ObjectNotFound();
            return value;
        }
        
        private cef_client_t.add_ref_delegate _ds0;
        private cef_client_t.release_delegate _ds1;
        private cef_client_t.has_one_ref_delegate _ds2;
        private cef_client_t.has_at_least_one_ref_delegate _ds3;
        private cef_client_t.get_audio_handler_delegate _ds4;
        private cef_client_t.get_command_handler_delegate _ds5;
        private cef_client_t.get_context_menu_handler_delegate _ds6;
        private cef_client_t.get_dialog_handler_delegate _ds7;
        private cef_client_t.get_display_handler_delegate _ds8;
        private cef_client_t.get_download_handler_delegate _ds9;
        private cef_client_t.get_drag_handler_delegate _dsa;
        private cef_client_t.get_find_handler_delegate _dsb;
        private cef_client_t.get_focus_handler_delegate _dsc;
        private cef_client_t.get_frame_handler_delegate _dsd;
        private cef_client_t.get_permission_handler_delegate _dse;
        private cef_client_t.get_jsdialog_handler_delegate _dsf;
        private cef_client_t.get_keyboard_handler_delegate _ds10;
        private cef_client_t.get_life_span_handler_delegate _ds11;
        private cef_client_t.get_load_handler_delegate _ds12;
        private cef_client_t.get_print_handler_delegate _ds13;
        private cef_client_t.get_render_handler_delegate _ds14;
        private cef_client_t.get_request_handler_delegate _ds15;
        private cef_client_t.on_process_message_received_delegate _ds16;
        
        protected CefClient()
        {
            _self = cef_client_t.Alloc();
        
            _ds0 = new cef_client_t.add_ref_delegate(add_ref);
            _self->_base._add_ref = Marshal.GetFunctionPointerForDelegate(_ds0);
            _ds1 = new cef_client_t.release_delegate(release);
            _self->_base._release = Marshal.GetFunctionPointerForDelegate(_ds1);
            _ds2 = new cef_client_t.has_one_ref_delegate(has_one_ref);
            _self->_base._has_one_ref = Marshal.GetFunctionPointerForDelegate(_ds2);
            _ds3 = new cef_client_t.has_at_least_one_ref_delegate(has_at_least_one_ref);
            _self->_base._has_at_least_one_ref = Marshal.GetFunctionPointerForDelegate(_ds3);
            _ds4 = new cef_client_t.get_audio_handler_delegate(get_audio_handler);
            _self->_get_audio_handler = Marshal.GetFunctionPointerForDelegate(_ds4);
            _ds5 = new cef_client_t.get_command_handler_delegate(get_command_handler);
            _self->_get_command_handler = Marshal.GetFunctionPointerForDelegate(_ds5);
            _ds6 = new cef_client_t.get_context_menu_handler_delegate(get_context_menu_handler);
            _self->_get_context_menu_handler = Marshal.GetFunctionPointerForDelegate(_ds6);
            _ds7 = new cef_client_t.get_dialog_handler_delegate(get_dialog_handler);
            _self->_get_dialog_handler = Marshal.GetFunctionPointerForDelegate(_ds7);
            _ds8 = new cef_client_t.get_display_handler_delegate(get_display_handler);
            _self->_get_display_handler = Marshal.GetFunctionPointerForDelegate(_ds8);
            _ds9 = new cef_client_t.get_download_handler_delegate(get_download_handler);
            _self->_get_download_handler = Marshal.GetFunctionPointerForDelegate(_ds9);
            _dsa = new cef_client_t.get_drag_handler_delegate(get_drag_handler);
            _self->_get_drag_handler = Marshal.GetFunctionPointerForDelegate(_dsa);
            _dsb = new cef_client_t.get_find_handler_delegate(get_find_handler);
            _self->_get_find_handler = Marshal.GetFunctionPointerForDelegate(_dsb);
            _dsc = new cef_client_t.get_focus_handler_delegate(get_focus_handler);
            _self->_get_focus_handler = Marshal.GetFunctionPointerForDelegate(_dsc);
            _dsd = new cef_client_t.get_frame_handler_delegate(get_frame_handler);
            _self->_get_frame_handler = Marshal.GetFunctionPointerForDelegate(_dsd);
            _dse = new cef_client_t.get_permission_handler_delegate(get_permission_handler);
            _self->_get_permission_handler = Marshal.GetFunctionPointerForDelegate(_dse);
            _dsf = new cef_client_t.get_jsdialog_handler_delegate(get_jsdialog_handler);
            _self->_get_jsdialog_handler = Marshal.GetFunctionPointerForDelegate(_dsf);
            _ds10 = new cef_client_t.get_keyboard_handler_delegate(get_keyboard_handler);
            _self->_get_keyboard_handler = Marshal.GetFunctionPointerForDelegate(_ds10);
            _ds11 = new cef_client_t.get_life_span_handler_delegate(get_life_span_handler);
            _self->_get_life_span_handler = Marshal.GetFunctionPointerForDelegate(_ds11);
            _ds12 = new cef_client_t.get_load_handler_delegate(get_load_handler);
            _self->_get_load_handler = Marshal.GetFunctionPointerForDelegate(_ds12);
            _ds13 = new cef_client_t.get_print_handler_delegate(get_print_handler);
            _self->_get_print_handler = Marshal.GetFunctionPointerForDelegate(_ds13);
            _ds14 = new cef_client_t.get_render_handler_delegate(get_render_handler);
            _self->_get_render_handler = Marshal.GetFunctionPointerForDelegate(_ds14);
            _ds15 = new cef_client_t.get_request_handler_delegate(get_request_handler);
            _self->_get_request_handler = Marshal.GetFunctionPointerForDelegate(_ds15);
            _ds16 = new cef_client_t.on_process_message_received_delegate(on_process_message_received);
            _self->_on_process_message_received = Marshal.GetFunctionPointerForDelegate(_ds16);
        }
        
        ~CefClient()
        {
            Dispose(false);
        }
        
        protected virtual void Dispose(bool disposing)
        {
            if (_self != null)
            {
                cef_client_t.Free(_self);
                _self = null;
            }
        }
        
        private void add_ref(cef_client_t* self)
        {
            if (Interlocked.Increment(ref _refct) == 1)
            {
                lock (_roots) { _roots.Add((IntPtr)_self, this); }
            }
        }
        
        private int release(cef_client_t* self)
        {
            if (Interlocked.Decrement(ref _refct) == 0)
            {
                lock (_roots) { _roots.Remove((IntPtr)_self); }
                return 1;
            }
            return 0;
        }
        
        private int has_one_ref(cef_client_t* self)
        {
            return _refct == 1 ? 1 : 0;
        }
        
        private int has_at_least_one_ref(cef_client_t* self)
        {
            return _refct != 0 ? 1 : 0;
        }
        
        internal cef_client_t* ToNative()
        {
            add_ref(_self);
            return _self;
        }
        
        [Conditional("DEBUG")]
        private void CheckSelf(cef_client_t* self)
        {
            if (_self != self) throw ExceptionBuilder.InvalidSelfReference();
        }
        
    }
}