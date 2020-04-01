<!DOCTYPE html>
<html lang="en">
<head>
    <title>ConestogaHomes</title>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"></script>
    <style>

        .row {
            padding: 15px 10px;
        }

        h3 {
            margin: 10px;
            padding: 5px;
            text-decoration: underline;
        }

        .form {
            background-color: bisque;
        }
    </style>
</head>
<body>      <div class="row form">
            <div class="col-sm-12">
                <h3 class="text-left">Student Login</h3>
            </div>
            <div class="col-sm-4">
                <form action="/action_page.php">
                    <div class="form-group">
                        <label for="fname">First Name:</label>
                        <input type="text" class="form-control" id="fname" name="firstname">
                    </div>
                    <div class="form-group">
                        <label for="lname">Last Name:</label>
                        <input type="text" class="form-control" id="lname" name="lastname">
                    </div>
                    <div class="form-group">
                        <label for="sid">Student ID:</label>
                        <input type="text" class="form-control" id="sid" name="studentid">
                    </div>
                    <div class="form-group">
                        <label for="date">Date:</label>
                        <input type="date" class="form-control" id="date" name="date">
                    </div>
                    <div class="form-group">
                        <label for="cnum">Contact Number:</label>
                        <input type="int" class="form-control" id="cnum" name="Contact number">
                    </div>
                    <div class="form-group">
                        <label for="Address">Address:</label>
                        <textarea class="form-control" rows="5" id="Address"></textarea>
                    </div>
                    <button type="submit" class="btn btn-primary">Submit</button>
                </form>
            </div>

            <div class="col-sm-3">

            </div>
        </div>

        <div class="row form">
            <div class="col-sm-10">
                <h3 class="text-left">Owner Login</h3>
            </div>
            <div class="col-sm-4">
                <form action="/action_page.php">
                    <div class="form-group">
                        <label for="fname">First Name:</label>
                        <input type="text" class="form-control" id="fname" name="firstname">
                    </div>
                    <div class="form-group">
                        <label for="lname">Last Name:</label>
                        <input type="text" class="form-control" id="lname" name="lastname">
                    </div>
                    <div class="form-group">
                        <label for="cnum">Contact Number:</label>
                        <input type="text" class="form-control" id="cnum" name="Contact Number">
                    </div>
                    <div class="form-group">
                        <label for="id">ID Proof:</label>
                        <input type="text" class="form-control" id="id" name="id Proof">
                    </div>
                    <div class="form-group">
                        <label for="Address">Address:</label>
                        <textarea class="form-control" rows="5" id="Address"></textarea>
                    </div>
                    <button type="submit" class="btn btn-primary">Submit</button>
                </form>
            </div>
            <div class="col-sm-3">

            </div>
        </div>

    </div>
    </style>
</body>
</html>