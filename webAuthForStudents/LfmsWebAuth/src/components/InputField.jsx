import React from 'react'
import { forwardRef, useState } from "react";
import { Eye, EyeOff } from "lucide-react";


const InputField = forwardRef(function Input(
  { icon: Icon, type = "text", label, className = "", ...props },
  ref
) {
  const [show, setShow] = useState(false);
  const isPassword = type === "password";

  return (
    <div
      className={`flex items-center gap-3 border-b border-gray-400 pb-2
                  transition-colors focus-within:border-green-600 ${className}`}
    >
      {Icon && <Icon size={16} className="shrink-0 text-gray-500" />}

      <input
        ref={ref}
        type={isPassword && show ? "text" : type}
        aria-label={label || props.placeholder}
        className="min-w-0 flex-1 bg-transparent text-sm text-gray-900
                   outline-none placeholder:text-gray-500"
        {...props}
      />

      {isPassword && (
        <button
          type="button"
          onClick={() => setShow((s) => !s)}
          aria-label={show ? "Hide password" : "Show password"}
          className="shrink-0 text-gray-500 hover:text-gray-700
                     focus-visible:outline-2 focus-visible:outline-green-600"
        >
          {show ? <Eye size={16} /> : <EyeOff size={16} />}
        </button>
      )}
    </div>
  );
});

export default InputField;