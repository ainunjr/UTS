/* Style for sidebar */
#wrapper {
    display: flex;
    width: 100%;
}

#sidebar-wrapper {
    min-width: 250px;
    max-width: 250px;
    height: 100vh;
    position: fixed;
    background-color: #0047AB;
    color: white;
}

#page-content-wrapper {
    width: 100%;
    padding: 20px;
    margin-left: 250px;
}

#menu-toggle {
    margin-right: 20px;
}

.toggled #sidebar-wrapper {
    margin-left: -250px;
}

.sidebar-heading h5 {
    font-size: 1.1rem;
    margin-top: 10px;
}

.list-group-item {
    font-size: 1rem;
    padding: 15px 20px;
}

.list-group-item:hover {
    background-color: #007BFF;
}

.card-title {
    font-weight: bold;
    font-size: 1.2rem;
}

.card-text {
    font-size: 2rem;
    color: #333;
}
