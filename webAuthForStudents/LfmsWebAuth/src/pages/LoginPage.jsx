
import { useState } from "react";
import { Mail, Lock } from "lucide-react";
import { FcGoogle } from "react-icons/fc";
import { FaFacebookF } from "react-icons/fa";
import Input from "../components/InputField";
import Button from "../components/Button";
import LoginPanelImg from "../assets/LoginPageImage.jpg";

export default function LoginPage() {
  const [form, setForm] = useState({ email: "", password: "", remember: true });
  const [error, setError] = useState("");
  const [loading, setLoading] = useState(false);

  const handleChange = (e) => {
    const { name, value, type, checked } = e.target;
    setForm((f) => ({ ...f, [name]: type === "checkbox" ? checked : value }));
  };

  const handleSubmit = async (e) => {
    e.preventDefault();
    setError("");
    setLoading(true);
    try {      
      console.log(form);
    } catch {
      setError("Invalid email or password");
    } finally {
      setLoading(false);
    }
  };

    return (
    /* PAGE: grey background, centers the card */
    <div className="flex min-h-screen items-center justify-center bg-gray-400 px-2 py-[5px] font-sans">

      {/* CARD: two columns side by side */}
      <div className="flex min-h-[477px] w-full max-w-2xl overflow-hidden bg-white shadow-2xl">

        {/* LEFT: form */}
        <div className="w-full px-8 py-[29px] sm:px-12 md:w-1/2">
          <form onSubmit={handleSubmit} className="flex h-full flex-col">

            {/* Title */}
            <h1 className="mb-[37px] text-center text-3xl font-semibold text-gray-900">
              Log in
            </h1>

            {/* Fields */}
            <div className="space-y-[21px]">
              <Input
                icon={Mail}
                name="email"
                placeholder="Email or Phone Number"
                value={form.email}
                onChange={handleChange}
                required
              />
              <Input
                icon={Lock}
                type="password"
                name="password"
                placeholder="Password"
                value={form.password}
                onChange={handleChange}
                required
              />

              {/* Remember + Forgot */}
              <div className="flex items-center justify-between text-xs">
                <label className="flex cursor-pointer items-center gap-2 text-gray-600">
                  <input
                    type="checkbox"
                    name="remember"
                    checked={form.remember}
                    onChange={handleChange}
                    className="h-4 w-4 accent-green-600"
                  />
                  remember me
                </label>
                <a href="#" className="font-medium text-black underline">
                  Forgot Password ?
                </a>
              </div>
            </div>

            {/* Error message */}
            {error && (
              <p role="alert" className="mt-[13px] text-center text-xs text-red-600">
                {error}
              </p>
            )}

            {/* Main button */}
            <div className="mt-[37px]">
              <Button type="submit" disabled={loading}>
                {loading ? "Logging in..." : "Log in"}
              </Button>
            </div>

            {/* Social login */}
            <p className="mt-[21px] text-center text-xs text-gray-500">Log in with</p>
            <div className="mt-[9px] flex justify-center gap-6">
              <Button type="button" variant="social" aria-label="Log in with Google">
                <FcGoogle size={20} />
              </Button>
              <Button type="button" variant="social" aria-label="Log in with Facebook">
                <FaFacebookF size={16} className="text-[#1877f2]" />
              </Button>
            </div>

            {/* Register (pushed to the bottom by mt-auto) */}
            <div className="mt-auto pt-[29px] text-xs text-gray-500">
              Don't have an account ?
              <a href="#" className="block font-medium text-black underline">
                Register Now
              </a>
            </div>
          </form>
        </div>

        {/* RIGHT: image (hidden on mobile) */}
        <div className="hidden w-1/2 md:block">
          <img
            src={LoginPanelImg}
            alt=""
            className="h-full w-full object-cover"
          />
        </div>
      </div>
    </div>
  );
}