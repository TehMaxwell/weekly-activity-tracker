import type { Metadata } from "next";
import { notoSans } from "./ui/fonts";
import "./globals.css";

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
        {children}
      </body>
    </html>
  );
}
