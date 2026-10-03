// src/components/Button.jsx
const variants = {
  gradient:
    "w-full rounded-full bg-gradient-to-r from-[#3f6f8a] to-[#8bc96b] py-3 text-lg font-medium text-white shadow-md hover:opacity-90 active:scale-[0.98]",
  social:
    "flex h-10 w-24 items-center justify-center rounded-lg bg-white shadow-[0_2px_10px_rgba(0,0,0,0.15)] hover:shadow-lg",
};

export default function Button({
  variant = "gradient",
  className = "",
  children,
  ...props
}) {
  return (
    <button
      {...props}
      className={`transition disabled:cursor-not-allowed disabled:opacity-60 ${variants[variant]} ${className}`}
    >
      {children}
    </button>
  );
}