import type { Metadata } from "next";
import { notoSans } from "./ui/fonts";
import "./globals.css";
import SideNav from "./ui/sidenav";

export const metadata: Metadata = {
  title: "Weekly Activity Tracker",
  description: `Application for tracking weekly activity and achievements. 
                Notes of what has been achieved can be made, as well as targets set for the coming week.`
};

export default function RootLayout({
  children,
}: Readonly<{
  children: React.ReactNode;
}>) {
  return (
    <html lang="en">
      <body className={`${notoSans.className} antialiased`}>
        <div className="flex h-screen flex-col md:flex-row md:overflow-hidden">
          <div className="w-full flex-none md:w-64">
            <SideNav />
          </div>
          <div className="flex-grow p-6 md:overflow-y-auto md:p-12">{children}</div>
        </div>
        {children}
      </body>
    </html>
  );
}
