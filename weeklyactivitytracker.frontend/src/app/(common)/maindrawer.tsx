// CLIENT USAGE DIRECTIVE
"use client"

// REACT COMPONENTS
import * as React from 'react';

// UI COMPONENTS
import Box from '@mui/material/Box';
import Drawer from '@mui/material/Drawer';
import Button from '@mui/material/Button';
import List from '@mui/material/List';
import Divider from '@mui/material/Divider';
import ListItem from '@mui/material/ListItem';
import ListItemButton from '@mui/material/ListItemButton';
import ListItemIcon from '@mui/material/ListItemIcon';
import ListItemText from '@mui/material/ListItemText';

// DEFINITIONS
const homeSection:Array<string> = ['Home'];
const homeSectionRefs:Array<string> = ['./'];

const targetSection:Array<string> = ['Weekly Targets'];
const targetSectionRefs:Array<string> = ['./weeklytarget'];

export default function MainDrawer() {
  const [open, setOpen] = React.useState(false);

  const toggleDrawer = (newOpen: boolean) => () => {
    setOpen(newOpen);
  };

  const DrawerList = (
    <Box sx={{ width: 250 }} role="presentation" onClick={toggleDrawer(false)}>
      <List>
        {homeSection.map((text, index) => (
          <ListItem key={text} disablePadding>
            <ListItemButton href={homeSectionRefs[index]}>
              <ListItemText primary={text}/>
            </ListItemButton>
          </ListItem>
        ))}
      </List>
      <Divider />
      <List>
        {targetSection.map((text, index) => (
          <ListItem key={text} disablePadding>
            <ListItemButton href={targetSectionRefs[index]}>
              <ListItemText primary={text} />
            </ListItemButton>
          </ListItem>
        ))}
      </List>
    </Box>
  );

  return (
    <div>
      <Button onClick={toggleDrawer(true)}>Open drawer</Button>
      <Drawer open={open} onClose={toggleDrawer(false)}>
        {DrawerList}
      </Drawer>
    </div>
  );
}
