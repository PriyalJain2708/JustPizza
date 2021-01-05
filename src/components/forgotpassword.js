import React from 'react'
import { Grid,Paper, Icon, TextField, Button, Typography } from '@material-ui/core';
import { Link } from "react-router-dom";
import FormControlLabel from '@material-ui/core/FormControlLabel';
import VpnKeyIcon from '@material-ui/icons/VpnKey';
import VpnKey from '@material-ui/icons/VpnKey';
import Checkbox from '@material-ui/core/Checkbox';
import Login from './Login';

const ForgotPassword=()=>{

    const paperStyle={padding :20,height:'70vh',width:280, margin:"80px auto"}
    const avatarStyle={ color: '#1bbd7e', fontSize: '35px' }
    const btnstyle={margin:'8px 0', backgroundColor: '#1bbd7e'}
    return(
        <Grid>
            <Paper elevation={10} style={paperStyle}>
                <Grid align='center'>
                     <VpnKeyIcon style={avatarStyle}><VpnKey/></VpnKeyIcon>
                    <h2>Forgot Password</h2>
                </Grid>
                <TextField label='Enter name' placeholder='Enter name' fullWidth required/>
                <TextField label='Enter new password' placeholder='Enter new password' type='password' fullWidth required/>
                <TextField label='Confirm password' placeholder='Confirm password' type='number' fullWidth required/>
                
                <FormControlLabel
                    control={
                    <Checkbox
                        name="checkedB"
                        color="primary"
                    />
                    }
                    label="Remember me"
                 />
                <Button type='submit' color='primary' variant="contained" style={btnstyle} fullWidth>
                <Link to= "/login" style = {{textDecoration: 'none', color:'white'}}>CONFIRM</Link></Button>
            </Paper>
        </Grid>
    )
}

export default ForgotPassword;