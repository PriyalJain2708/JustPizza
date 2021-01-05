import React from 'react'
import { Link } from "react-router-dom";
import { Grid,Paper, Avatar, TextField, Button, Typography } from '@material-ui/core'
import LockOutlinedIcon from '@material-ui/icons/LockOutlined';
import FormControlLabel from '@material-ui/core/FormControlLabel';
import Checkbox from '@material-ui/core/Checkbox';
import SearchBar from './SearchBar/SearchBar';
import SignUp from './signup';
const Login=()=>{

    const paperStyle={padding :20,height:'70vh',width:280, margin:"80px auto"}
    const avatarStyle={backgroundColor:'#1bbd7e'}
    const btnstyle={margin:'8px 0', backgroundColor: '#1bbd7e'}
    return(
        <Grid>
            <Paper elevation={10} style={paperStyle}>
                <Grid align='center'>
                     <Avatar style={avatarStyle}><LockOutlinedIcon/></Avatar>
                    <h2>Log In</h2>
                </Grid>
                <TextField label='name' placeholder='Enter name' fullWidth required/>
                <TextField label='password' placeholder='Enter password' type='password' fullWidth required/>
                <FormControlLabel
                    control={
                    <Checkbox
                        name="checkedB"
                        color="primary"
                    />
                    }
                    label="Remember me"
                 />
                <Button type='submit' color="primary" variant="contained" style={btnstyle} fullWidth>
                <Link to= "/SearchBar" style={{color: "white", textDecoration: 'none'}}>Sign in</Link></Button>
                <Typography >
                     <Link to="forgotpassword" style = {{textDecoration: 'none', color:'black'}}>
                        Forgot password ?
                </Link>
                </Typography>
                <Typography > Do you have an account ?
                <Link to= "/signup" style = {{textDecoration: 'none', color:'black'}}> SignUp </Link>
                </Typography>
            </Paper>
        </Grid>
    )
}

export default Login;