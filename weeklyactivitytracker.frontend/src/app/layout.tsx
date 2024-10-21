// PACKAGES
import type { Metadata } from "next";

// FONTS
import '@fontsource/roboto/300.css';
import '@fontsource/roboto/400.css';
import '@fontsource/roboto/500.css';
import '@fontsource/roboto/700.css';
import { notoSans } from "./ui/fonts";

// UI COMPONENTS
import MainDrawer from './(common)/maindrawer';

//STYLING
import "./globals.css";

// Application Metadata
export const metadata: Metadata = {
  title: "Weekly Activity Tracker",
  description: `Application for tracking weekly activity and achievements. 
                Notes of what has been achieved can be made, as well as targets set for the coming week.`
};

// Default Layout
export default function RootLayout({
  children,
}: Readonly<{
  children: React.ReactNode;
}>) {
  return (
    <html lang="en">
      <body className={`${notoSans.className} antialiased`}>
        <MainDrawer></MainDrawer>
        {children}
      </body>
    </html>
  );
}
