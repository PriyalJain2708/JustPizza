import React from 'react';
import { Link } from "react-router-dom";
import { Grid,Paper, Avatar, TextField, Button, Typography} from '@material-ui/core';
import AssignmentIcon from '@material-ui/icons/Assignment';

const SignUp=()=>{
    const paperStyle={padding :20,height:'70vh',width:280, margin:"80px auto"}
    const avatarStyle={  color: '#fff', backgroundColor: '#1bbd7e' }
    const btnstyle={margin:'30px 0', backgroundColor: '#1bbd7e'}
    return(
        <Grid>
            <Paper elevation={10} style={paperStyle}>
                <Grid align='center'>
                <Avatar style ={avatarStyle}><AssignmentIcon /></Avatar>
                    <h2>Sign Up</h2>
                </Grid>
                <TextField label='Enter name' placeholder='Enter name' fullWidth required/>
                <TextField label='password' placeholder='Enter password' type='password' fullWidth required/>
                <TextField label='Date of Birth' placeholder='Date of Birth' type='number' fullWidth required/>
                <TextField label='city' placeholder='city' type='text' fullWidth required/>
                
                <Button type='submit' color='primary' variant="contained" style={btnstyle} fullWidth>
                <Link to= "/login" style = {{textDecoration: 'none', color:'white'}}>Confirm</Link></Button>
            </Paper>
        </Grid>
    )
}

export default SignUp;
